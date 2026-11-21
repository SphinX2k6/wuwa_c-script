using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001430 RID: 5168
	[NetMessage(EMessageId.TowerGuideActivityInfoResponse)]
	public sealed class TowerGuideActivityInfoResponse : IMessage<TowerGuideActivityInfoResponse>, IMessage, IEquatable<TowerGuideActivityInfoResponse>, IDeepCloneable<TowerGuideActivityInfoResponse>, IBufferMessage
	{
		// Token: 0x0601B76D RID: 112493 RVA: 0x003FE2BE File Offset: 0x003FC4BE
		[NullableContext(1)]
		public static TowerGuideActivityInfoResponse Create()
		{
			return new TowerGuideActivityInfoResponse();
		}

		// Token: 0x17005CFC RID: 23804
		// (get) Token: 0x0601B76E RID: 112494 RVA: 0x003FE2C5 File Offset: 0x003FC4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CFD RID: 23805
		// (get) Token: 0x0601B76F RID: 112495 RVA: 0x003FE2C8 File Offset: 0x003FC4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerGuideActivityInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601B770 RID: 112496 RVA: 0x003FE2CF File Offset: 0x003FC4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityInfoResponse()
		{
		}

		// Token: 0x0601B771 RID: 112497 RVA: 0x003FE2E2 File Offset: 0x003FC4E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityInfoResponse(TowerGuideActivityInfoResponse other) : this()
		{
			this.towerGuideId_ = other.towerGuideId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B772 RID: 112498 RVA: 0x003FE30C File Offset: 0x003FC50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityInfoResponse Clone()
		{
			return new TowerGuideActivityInfoResponse(this);
		}

		// Token: 0x17005CFE RID: 23806
		// (get) Token: 0x0601B773 RID: 112499 RVA: 0x003FE314 File Offset: 0x003FC514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TowerGuideId
		{
			get
			{
				return this.towerGuideId_;
			}
		}

		// Token: 0x0601B774 RID: 112500 RVA: 0x003FE31C File Offset: 0x003FC51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerGuideActivityInfoResponse);
		}

		// Token: 0x0601B775 RID: 112501 RVA: 0x003FE32A File Offset: 0x003FC52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerGuideActivityInfoResponse other)
		{
			return other != null && (other == this || (this.towerGuideId_.Equals(other.towerGuideId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B776 RID: 112502 RVA: 0x003FE360 File Offset: 0x003FC560
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

		// Token: 0x0601B777 RID: 112503 RVA: 0x003FE394 File Offset: 0x003FC594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B778 RID: 112504 RVA: 0x003FE3A1 File Offset: 0x003FC5A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B779 RID: 112505 RVA: 0x003FE3AA File Offset: 0x003FC5AA
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

		// Token: 0x0601B77A RID: 112506 RVA: 0x003FE3D4 File Offset: 0x003FC5D4
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

		// Token: 0x0601B77B RID: 112507 RVA: 0x003FE40D File Offset: 0x003FC60D
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

		// Token: 0x0601B77C RID: 112508 RVA: 0x003FE43B File Offset: 0x003FC63B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B77D RID: 112509 RVA: 0x003FE444 File Offset: 0x003FC644
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.towerGuideId_.AddEntriesFrom(ref input, TowerGuideActivityInfoResponse._repeated_towerGuideId_codec);
				}
			}
		}

		// Token: 0x04009FE0 RID: 40928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FE1 RID: 40929
		public const int TowerGuideIdFieldNumber = 5;

		// Token: 0x04009FE2 RID: 40930
		private static readonly FieldCodec<int> _repeated_towerGuideId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04009FE3 RID: 40931
		private readonly RepeatedField<int> towerGuideId_ = new RepeatedField<int>();
	}
}
