using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001FA RID: 506
	[NetMessage(EMessageId.BtVarUpdateNotify)]
	public sealed class BtVarUpdateNotify : IMessage<BtVarUpdateNotify>, IMessage, IEquatable<BtVarUpdateNotify>, IDeepCloneable<BtVarUpdateNotify>, IBufferMessage
	{
		// Token: 0x06003878 RID: 14456 RVA: 0x0008D711 File Offset: 0x0008B911
		[NullableContext(1)]
		public static BtVarUpdateNotify Create()
		{
			return new BtVarUpdateNotify();
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06003879 RID: 14457 RVA: 0x0008D718 File Offset: 0x0008B918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x0600387A RID: 14458 RVA: 0x0008D71B File Offset: 0x0008B91B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtVarUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x0008D722 File Offset: 0x0008B922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtVarUpdateNotify()
		{
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x0008D738 File Offset: 0x0008B938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtVarUpdateNotify(BtVarUpdateNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.varName_ = other.varName_;
			this.varDefine_ = ((other.varDefine_ != null) ? other.varDefine_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x0008D79C File Offset: 0x0008B99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtVarUpdateNotify Clone()
		{
			return new BtVarUpdateNotify(this);
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x0600387E RID: 14462 RVA: 0x0008D7A4 File Offset: 0x0008B9A4
		// (set) Token: 0x0600387F RID: 14463 RVA: 0x0008D7AC File Offset: 0x0008B9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06003880 RID: 14464 RVA: 0x0008D7B5 File Offset: 0x0008B9B5
		// (set) Token: 0x06003881 RID: 14465 RVA: 0x0008D7BD File Offset: 0x0008B9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06003882 RID: 14466 RVA: 0x0008D7C6 File Offset: 0x0008B9C6
		// (set) Token: 0x06003883 RID: 14467 RVA: 0x0008D7CE File Offset: 0x0008B9CE
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

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06003884 RID: 14468 RVA: 0x0008D7E1 File Offset: 0x0008B9E1
		// (set) Token: 0x06003885 RID: 14469 RVA: 0x0008D7E9 File Offset: 0x0008B9E9
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

		// Token: 0x06003886 RID: 14470 RVA: 0x0008D7F2 File Offset: 0x0008B9F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtVarUpdateNotify);
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x0008D800 File Offset: 0x0008BA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtVarUpdateNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && !(this.VarName != other.VarName) && object.Equals(this.VarDefine, other.VarDefine) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x0008D874 File Offset: 0x0008BA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
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

		// Token: 0x06003889 RID: 14473 RVA: 0x0008D8FD File Offset: 0x0008BAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x0008D90A File Offset: 0x0008BB0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x0008D914 File Offset: 0x0008BB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.VarName.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.VarName);
			}
			if (this.varDefine_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.VarDefine);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x0008D9AC File Offset: 0x0008BBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
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

		// Token: 0x0600388D RID: 14477 RVA: 0x0008DA38 File Offset: 0x0008BC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtVarUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
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

		// Token: 0x0600388E RID: 14478 RVA: 0x0008DACD File Offset: 0x0008BCCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600388F RID: 14479 RVA: 0x0008DAD8 File Offset: 0x0008BCD8
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
				if (num <= 42U)
				{
					if (num == 16U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 42U)
					{
						this.VarName = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						if (this.varDefine_ == null)
						{
							this.VarDefine = new VarDefinePb();
						}
						input.ReadMessage(this.VarDefine);
						continue;
					}
					if (num == 112U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B8B RID: 11147
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B8C RID: 11148
		public const int TreeOwnerIdFieldNumber = 14;

		// Token: 0x04002B8D RID: 11149
		private int treeOwnerId_;

		// Token: 0x04002B8E RID: 11150
		public const int TreeIncIdFieldNumber = 2;

		// Token: 0x04002B8F RID: 11151
		private long treeIncId_;

		// Token: 0x04002B90 RID: 11152
		public const int VarNameFieldNumber = 5;

		// Token: 0x04002B91 RID: 11153
		private string varName_ = "";

		// Token: 0x04002B92 RID: 11154
		public const int VarDefineFieldNumber = 7;

		// Token: 0x04002B93 RID: 11155
		private VarDefinePb varDefine_;
	}
}
