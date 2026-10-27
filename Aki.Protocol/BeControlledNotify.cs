using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200018A RID: 394
	[NetMessage(EMessageId.BeControlledNotify)]
	public sealed class BeControlledNotify : IMessage<BeControlledNotify>, IMessage, IEquatable<BeControlledNotify>, IDeepCloneable<BeControlledNotify>, IBufferMessage
	{
		// Token: 0x06002F43 RID: 12099 RVA: 0x000791FD File Offset: 0x000773FD
		[NullableContext(1)]
		public static BeControlledNotify Create()
		{
			return new BeControlledNotify();
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06002F44 RID: 12100 RVA: 0x00079204 File Offset: 0x00077404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06002F45 RID: 12101 RVA: 0x00079207 File Offset: 0x00077407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledNotify.Descriptor;
			}
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x0007920E File Offset: 0x0007740E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledNotify()
		{
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x00079216 File Offset: 0x00077416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledNotify(BeControlledNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.roleEntityId_ = other.roleEntityId_;
			this.needReset_ = other.needReset_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x00079253 File Offset: 0x00077453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledNotify Clone()
		{
			return new BeControlledNotify(this);
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06002F49 RID: 12105 RVA: 0x0007925B File Offset: 0x0007745B
		// (set) Token: 0x06002F4A RID: 12106 RVA: 0x00079263 File Offset: 0x00077463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06002F4B RID: 12107 RVA: 0x0007926C File Offset: 0x0007746C
		// (set) Token: 0x06002F4C RID: 12108 RVA: 0x00079274 File Offset: 0x00077474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RoleEntityId
		{
			get
			{
				return this.roleEntityId_;
			}
			set
			{
				this.roleEntityId_ = value;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06002F4D RID: 12109 RVA: 0x0007927D File Offset: 0x0007747D
		// (set) Token: 0x06002F4E RID: 12110 RVA: 0x00079285 File Offset: 0x00077485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedReset
		{
			get
			{
				return this.needReset_;
			}
			set
			{
				this.needReset_ = value;
			}
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x0007928E File Offset: 0x0007748E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledNotify);
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x0007929C File Offset: 0x0007749C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.RoleEntityId == other.RoleEntityId && this.NeedReset == other.NeedReset && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x000792F8 File Offset: 0x000774F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.RoleEntityId != 0L)
			{
				num ^= this.RoleEntityId.GetHashCode();
			}
			if (this.NeedReset)
			{
				num ^= this.NeedReset.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x00079369 File Offset: 0x00077569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x00079376 File Offset: 0x00077576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x00079380 File Offset: 0x00077580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.NeedReset)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.NeedReset);
			}
			if (this.RoleEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.RoleEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x000793F8 File Offset: 0x000775F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.RoleEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RoleEntityId);
			}
			if (this.NeedReset)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x0007945C File Offset: 0x0007765C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.RoleEntityId != 0L)
			{
				this.RoleEntityId = other.RoleEntityId;
			}
			if (other.NeedReset)
			{
				this.NeedReset = other.NeedReset;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x000794C0 File Offset: 0x000776C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x000794CC File Offset: 0x000776CC
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
				if (num != 16U)
				{
					if (num != 40U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RoleEntityId = input.ReadInt64();
						}
					}
					else
					{
						this.NeedReset = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040028A2 RID: 10402
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028A3 RID: 10403
		public const int EntityIdFieldNumber = 2;

		// Token: 0x040028A4 RID: 10404
		private long entityId_;

		// Token: 0x040028A5 RID: 10405
		public const int RoleEntityIdFieldNumber = 8;

		// Token: 0x040028A6 RID: 10406
		private long roleEntityId_;

		// Token: 0x040028A7 RID: 10407
		public const int NeedResetFieldNumber = 5;

		// Token: 0x040028A8 RID: 10408
		private bool needReset_;
	}
}
