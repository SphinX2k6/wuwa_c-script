using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004CC RID: 1228
	[NetMessage(EMessageId.EntityVarUpdateNotify)]
	public sealed class EntityVarUpdateNotify : IMessage<EntityVarUpdateNotify>, IMessage, IEquatable<EntityVarUpdateNotify>, IDeepCloneable<EntityVarUpdateNotify>, IBufferMessage
	{
		// Token: 0x060074B8 RID: 29880 RVA: 0x0011DFDB File Offset: 0x0011C1DB
		[NullableContext(1)]
		public static EntityVarUpdateNotify Create()
		{
			return new EntityVarUpdateNotify();
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x060074B9 RID: 29881 RVA: 0x0011DFE2 File Offset: 0x0011C1E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x060074BA RID: 29882 RVA: 0x0011DFE5 File Offset: 0x0011C1E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityVarUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x0011DFEC File Offset: 0x0011C1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityVarUpdateNotify()
		{
		}

		// Token: 0x060074BC RID: 29884 RVA: 0x0011E000 File Offset: 0x0011C200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityVarUpdateNotify(EntityVarUpdateNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.varName_ = other.varName_;
			this.varDefine_ = ((other.varDefine_ != null) ? other.varDefine_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074BD RID: 29885 RVA: 0x0011E058 File Offset: 0x0011C258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityVarUpdateNotify Clone()
		{
			return new EntityVarUpdateNotify(this);
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x060074BE RID: 29886 RVA: 0x0011E060 File Offset: 0x0011C260
		// (set) Token: 0x060074BF RID: 29887 RVA: 0x0011E068 File Offset: 0x0011C268
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

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x060074C0 RID: 29888 RVA: 0x0011E071 File Offset: 0x0011C271
		// (set) Token: 0x060074C1 RID: 29889 RVA: 0x0011E079 File Offset: 0x0011C279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string VarName
		{
			get
			{
				return this.varName_;
			}
			set
			{
				this.varName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x060074C2 RID: 29890 RVA: 0x0011E08C File Offset: 0x0011C28C
		// (set) Token: 0x060074C3 RID: 29891 RVA: 0x0011E094 File Offset: 0x0011C294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarDefinePb VarDefine
		{
			get
			{
				return this.varDefine_;
			}
			set
			{
				this.varDefine_ = value;
			}
		}

		// Token: 0x060074C4 RID: 29892 RVA: 0x0011E09D File Offset: 0x0011C29D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityVarUpdateNotify);
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x0011E0AC File Offset: 0x0011C2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityVarUpdateNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.VarName != other.VarName) && object.Equals(this.VarDefine, other.VarDefine) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060074C6 RID: 29894 RVA: 0x0011E110 File Offset: 0x0011C310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.VarName.Length != 0)
			{
				num ^= this.VarName.GetHashCode();
			}
			if (this.varDefine_ != null)
			{
				num ^= this.VarDefine.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060074C7 RID: 29895 RVA: 0x0011E180 File Offset: 0x0011C380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060074C8 RID: 29896 RVA: 0x0011E18D File Offset: 0x0011C38D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074C9 RID: 29897 RVA: 0x0011E198 File Offset: 0x0011C398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.varDefine_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.VarDefine);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.VarName.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.VarName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060074CA RID: 29898 RVA: 0x0011E214 File Offset: 0x0011C414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.VarName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.VarName);
			}
			if (this.varDefine_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.VarDefine);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060074CB RID: 29899 RVA: 0x0011E288 File Offset: 0x0011C488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityVarUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.VarName.Length != 0)
			{
				this.VarName = other.VarName;
			}
			if (other.varDefine_ != null)
			{
				if (this.varDefine_ == null)
				{
					this.VarDefine = new VarDefinePb();
				}
				this.VarDefine.MergeFrom(other.VarDefine);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060074CC RID: 29900 RVA: 0x0011E309 File Offset: 0x0011C509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x0011E314 File Offset: 0x0011C514
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
				if (num != 50U)
				{
					if (num != 72U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.VarName = input.ReadString();
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					if (this.varDefine_ == null)
					{
						this.VarDefine = new VarDefinePb();
					}
					input.ReadMessage(this.VarDefine);
				}
			}
		}

		// Token: 0x04003D81 RID: 15745
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D82 RID: 15746
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04003D83 RID: 15747
		private long entityId_;

		// Token: 0x04003D84 RID: 15748
		public const int VarNameFieldNumber = 11;

		// Token: 0x04003D85 RID: 15749
		private string varName_ = "";

		// Token: 0x04003D86 RID: 15750
		public const int VarDefineFieldNumber = 6;

		// Token: 0x04003D87 RID: 15751
		private VarDefinePb varDefine_;
	}
}
