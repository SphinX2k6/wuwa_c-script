using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013BD RID: 5053
	[NetMessage(EMessageId.TowerGuideActivityInfoResponse)]
	public sealed class TowerGuideActivityInfoResponse : IMessage<TowerGuideActivityInfoResponse>, IMessage, IEquatable<TowerGuideActivityInfoResponse>, IDeepCloneable<TowerGuideActivityInfoResponse>, IBufferMessage
	{
		// Token: 0x0601ACE2 RID: 109794 RVA: 0x003E2FFA File Offset: 0x003E11FA
		[NullableContext(1)]
		public static TowerGuideActivityInfoResponse Create()
		{
			return new TowerGuideActivityInfoResponse();
		}

		// Token: 0x17005A67 RID: 23143
		// (get) Token: 0x0601ACE3 RID: 109795 RVA: 0x003E3001 File Offset: 0x003E1201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A68 RID: 23144
		// (get) Token: 0x0601ACE4 RID: 109796 RVA: 0x003E3004 File Offset: 0x003E1204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerGuideActivityInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601ACE5 RID: 109797 RVA: 0x003E300B File Offset: 0x003E120B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityInfoResponse()
		{
		}

		// Token: 0x0601ACE6 RID: 109798 RVA: 0x003E301E File Offset: 0x003E121E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityInfoResponse(TowerGuideActivityInfoResponse other) : this()
		{
			this.towerGuideId_ = other.towerGuideId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ACE7 RID: 109799 RVA: 0x003E3048 File Offset: 0x003E1248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityInfoResponse Clone()
		{
			return new TowerGuideActivityInfoResponse(this);
		}

		// Token: 0x17005A69 RID: 23145
		// (get) Token: 0x0601ACE8 RID: 109800 RVA: 0x003E3050 File Offset: 0x003E1250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TowerGuideId
		{
			get
			{
				return this.towerGuideId_;
			}
		}

		// Token: 0x0601ACE9 RID: 109801 RVA: 0x003E3058 File Offset: 0x003E1258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerGuideActivityInfoResponse);
		}

		// Token: 0x0601ACEA RID: 109802 RVA: 0x003E3066 File Offset: 0x003E1266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerGuideActivityInfoResponse other)
		{
			return other != null && (other == this || (this.towerGuideId_.Equals(other.towerGuideId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ACEB RID: 109803 RVA: 0x003E309C File Offset: 0x003E129C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.towerGuideId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ACEC RID: 109804 RVA: 0x003E30D0 File Offset: 0x003E12D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ACED RID: 109805 RVA: 0x003E30DD File Offset: 0x003E12DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ACEE RID: 109806 RVA: 0x003E30E6 File Offset: 0x003E12E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.towerGuideId_.WriteTo(ref output, TowerGuideActivityInfoResponse._repeated_towerGuideId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ACEF RID: 109807 RVA: 0x003E3110 File Offset: 0x003E1310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.towerGuideId_.CalculateSize(TowerGuideActivityInfoResponse._repeated_towerGuideId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ACF0 RID: 109808 RVA: 0x003E3149 File Offset: 0x003E1349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerGuideActivityInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.towerGuideId_.Add(other.towerGuideId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ACF1 RID: 109809 RVA: 0x003E3177 File Offset: 0x003E1377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ACF2 RID: 109810 RVA: 0x003E3180 File Offset: 0x003E1380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.towerGuideId_.AddEntriesFrom(ref input, TowerGuideActivityInfoResponse._repeated_towerGuideId_codec);
				}
			}
		}

		// Token: 0x04009B99 RID: 39833
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B9A RID: 39834
		public const int TowerGuideIdFieldNumber = 4;

		// Token: 0x04009B9B RID: 39835
		private static readonly FieldCodec<int> _repeated_towerGuideId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04009B9C RID: 39836
		private readonly RepeatedField<int> towerGuideId_ = new RepeatedField<int>();
	}
}
