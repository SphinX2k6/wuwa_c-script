using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001229 RID: 4649
	public sealed class SimpleCombatSplineMovePbType : IMessage<SimpleCombatSplineMovePbType>, IMessage, IEquatable<SimpleCombatSplineMovePbType>, IDeepCloneable<SimpleCombatSplineMovePbType>, IBufferMessage
	{
		// Token: 0x06018C69 RID: 101481 RVA: 0x0039AF6C File Offset: 0x0039916C
		[NullableContext(1)]
		public static SimpleCombatSplineMovePbType Create()
		{
			return new SimpleCombatSplineMovePbType();
		}

		// Token: 0x17005381 RID: 21377
		// (get) Token: 0x06018C6A RID: 101482 RVA: 0x0039AF73 File Offset: 0x00399173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005382 RID: 21378
		// (get) Token: 0x06018C6B RID: 101483 RVA: 0x0039AF76 File Offset: 0x00399176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatSplineMovePbType.Descriptor;
			}
		}

		// Token: 0x06018C6C RID: 101484 RVA: 0x0039AF7D File Offset: 0x0039917D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatSplineMovePbType()
		{
		}

		// Token: 0x06018C6D RID: 101485 RVA: 0x0039AF85 File Offset: 0x00399185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatSplineMovePbType(SimpleCombatSplineMovePbType other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018C6E RID: 101486 RVA: 0x0039AFAA File Offset: 0x003991AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatSplineMovePbType Clone()
		{
			return new SimpleCombatSplineMovePbType(this);
		}

		// Token: 0x17005383 RID: 21379
		// (get) Token: 0x06018C6F RID: 101487 RVA: 0x0039AFB2 File Offset: 0x003991B2
		// (set) Token: 0x06018C70 RID: 101488 RVA: 0x0039AFBA File Offset: 0x003991BA
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

		// Token: 0x06018C71 RID: 101489 RVA: 0x0039AFC3 File Offset: 0x003991C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatSplineMovePbType);
		}

		// Token: 0x06018C72 RID: 101490 RVA: 0x0039AFD1 File Offset: 0x003991D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatSplineMovePbType other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018C73 RID: 101491 RVA: 0x0039B000 File Offset: 0x00399200
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

		// Token: 0x06018C74 RID: 101492 RVA: 0x0039B03F File Offset: 0x0039923F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018C75 RID: 101493 RVA: 0x0039B04C File Offset: 0x0039924C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018C76 RID: 101494 RVA: 0x0039B055 File Offset: 0x00399255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018C77 RID: 101495 RVA: 0x0039B088 File Offset: 0x00399288
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

		// Token: 0x06018C78 RID: 101496 RVA: 0x0039B0C6 File Offset: 0x003992C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatSplineMovePbType other)
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

		// Token: 0x06018C79 RID: 101497 RVA: 0x0039B0F7 File Offset: 0x003992F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018C7A RID: 101498 RVA: 0x0039B100 File Offset: 0x00399300
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009231 RID: 37425
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009232 RID: 37426
		public const int ConfigIdFieldNumber = 3;

		// Token: 0x04009233 RID: 37427
		private int configId_;
	}
}
