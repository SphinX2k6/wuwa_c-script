using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B4 RID: 5044
	[NetMessage(EMessageId.TowerDefenceSelfPassResponse)]
	public sealed class TowerDefenceSelfPassResponse : IMessage<TowerDefenceSelfPassResponse>, IMessage, IEquatable<TowerDefenceSelfPassResponse>, IDeepCloneable<TowerDefenceSelfPassResponse>, IBufferMessage
	{
		// Token: 0x0601AC2A RID: 109610 RVA: 0x003E16FD File Offset: 0x003DF8FD
		[NullableContext(1)]
		public static TowerDefenceSelfPassResponse Create()
		{
			return new TowerDefenceSelfPassResponse();
		}

		// Token: 0x17005A3F RID: 23103
		// (get) Token: 0x0601AC2B RID: 109611 RVA: 0x003E1704 File Offset: 0x003DF904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A40 RID: 23104
		// (get) Token: 0x0601AC2C RID: 109612 RVA: 0x003E1707 File Offset: 0x003DF907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceSelfPassResponse.Descriptor;
			}
		}

		// Token: 0x0601AC2D RID: 109613 RVA: 0x003E170E File Offset: 0x003DF90E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceSelfPassResponse()
		{
		}

		// Token: 0x0601AC2E RID: 109614 RVA: 0x003E1721 File Offset: 0x003DF921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceSelfPassResponse(TowerDefenceSelfPassResponse other) : this()
		{
			this.selfPassData_ = other.selfPassData_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AC2F RID: 109615 RVA: 0x003E174B File Offset: 0x003DF94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceSelfPassResponse Clone()
		{
			return new TowerDefenceSelfPassResponse(this);
		}

		// Token: 0x17005A41 RID: 23105
		// (get) Token: 0x0601AC30 RID: 109616 RVA: 0x003E1753 File Offset: 0x003DF953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneTowerDefencePassInfo> SelfPassData
		{
			get
			{
				return this.selfPassData_;
			}
		}

		// Token: 0x0601AC31 RID: 109617 RVA: 0x003E175B File Offset: 0x003DF95B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceSelfPassResponse);
		}

		// Token: 0x0601AC32 RID: 109618 RVA: 0x003E1769 File Offset: 0x003DF969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceSelfPassResponse other)
		{
			return other != null && (other == this || (this.selfPassData_.Equals(other.selfPassData_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AC33 RID: 109619 RVA: 0x003E179C File Offset: 0x003DF99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.selfPassData_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AC34 RID: 109620 RVA: 0x003E17D0 File Offset: 0x003DF9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AC35 RID: 109621 RVA: 0x003E17DD File Offset: 0x003DF9DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AC36 RID: 109622 RVA: 0x003E17E6 File Offset: 0x003DF9E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.selfPassData_.WriteTo(ref output, TowerDefenceSelfPassResponse._repeated_selfPassData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AC37 RID: 109623 RVA: 0x003E1810 File Offset: 0x003DFA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.selfPassData_.CalculateSize(TowerDefenceSelfPassResponse._repeated_selfPassData_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AC38 RID: 109624 RVA: 0x003E1849 File Offset: 0x003DFA49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceSelfPassResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.selfPassData_.Add(other.selfPassData_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AC39 RID: 109625 RVA: 0x003E1877 File Offset: 0x003DFA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AC3A RID: 109626 RVA: 0x003E1880 File Offset: 0x003DFA80
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.selfPassData_.AddEntriesFrom(ref input, TowerDefenceSelfPassResponse._repeated_selfPassData_codec);
				}
			}
		}

		// Token: 0x04009B5E RID: 39774
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B5F RID: 39775
		public const int SelfPassDataFieldNumber = 1;

		// Token: 0x04009B60 RID: 39776
		private static readonly FieldCodec<OneTowerDefencePassInfo> _repeated_selfPassData_codec = FieldCodec.ForMessage<OneTowerDefencePassInfo>(10U, OneTowerDefencePassInfo.Parser);

		// Token: 0x04009B61 RID: 39777
		private readonly RepeatedField<OneTowerDefencePassInfo> selfPassData_ = new RepeatedField<OneTowerDefencePassInfo>();
	}
}
