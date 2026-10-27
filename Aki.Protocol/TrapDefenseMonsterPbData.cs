using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001432 RID: 5170
	public sealed class TrapDefenseMonsterPbData : IMessage<TrapDefenseMonsterPbData>, IMessage, IEquatable<TrapDefenseMonsterPbData>, IDeepCloneable<TrapDefenseMonsterPbData>, IBufferMessage
	{
		// Token: 0x0601B63B RID: 112187 RVA: 0x003F7583 File Offset: 0x003F5783
		[NullableContext(1)]
		public static TrapDefenseMonsterPbData Create()
		{
			return new TrapDefenseMonsterPbData();
		}

		// Token: 0x17005C5A RID: 23642
		// (get) Token: 0x0601B63C RID: 112188 RVA: 0x003F758A File Offset: 0x003F578A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C5B RID: 23643
		// (get) Token: 0x0601B63D RID: 112189 RVA: 0x003F758D File Offset: 0x003F578D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseMonsterPbData.Descriptor;
			}
		}

		// Token: 0x0601B63E RID: 112190 RVA: 0x003F7594 File Offset: 0x003F5794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterPbData()
		{
		}

		// Token: 0x0601B63F RID: 112191 RVA: 0x003F759C File Offset: 0x003F579C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterPbData(TrapDefenseMonsterPbData other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B640 RID: 112192 RVA: 0x003F75C1 File Offset: 0x003F57C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterPbData Clone()
		{
			return new TrapDefenseMonsterPbData(this);
		}

		// Token: 0x17005C5C RID: 23644
		// (get) Token: 0x0601B641 RID: 112193 RVA: 0x003F75C9 File Offset: 0x003F57C9
		// (set) Token: 0x0601B642 RID: 112194 RVA: 0x003F75D1 File Offset: 0x003F57D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x0601B643 RID: 112195 RVA: 0x003F75DA File Offset: 0x003F57DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseMonsterPbData);
		}

		// Token: 0x0601B644 RID: 112196 RVA: 0x003F75E8 File Offset: 0x003F57E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseMonsterPbData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B645 RID: 112197 RVA: 0x003F7618 File Offset: 0x003F5818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B646 RID: 112198 RVA: 0x003F7657 File Offset: 0x003F5857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B647 RID: 112199 RVA: 0x003F7664 File Offset: 0x003F5864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B648 RID: 112200 RVA: 0x003F766D File Offset: 0x003F586D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B649 RID: 112201 RVA: 0x003F76A0 File Offset: 0x003F58A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B64A RID: 112202 RVA: 0x003F76DE File Offset: 0x003F58DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseMonsterPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B64B RID: 112203 RVA: 0x003F770F File Offset: 0x003F590F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B64C RID: 112204 RVA: 0x003F7718 File Offset: 0x003F5918
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009E1D RID: 40477
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E1E RID: 40478
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04009E1F RID: 40479
		private int configId_;
	}
}
