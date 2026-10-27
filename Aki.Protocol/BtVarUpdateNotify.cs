using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F5 RID: 501
	[NetMessage(EMessageId.BtVarUpdateNotify)]
	public sealed class BtVarUpdateNotify : IMessage<BtVarUpdateNotify>, IMessage, IEquatable<BtVarUpdateNotify>, IDeepCloneable<BtVarUpdateNotify>, IBufferMessage
	{
		// Token: 0x060037D3 RID: 14291 RVA: 0x0008BB01 File Offset: 0x00089D01
		[NullableContext(1)]
		public static BtVarUpdateNotify Create()
		{
			return new BtVarUpdateNotify();
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060037D4 RID: 14292 RVA: 0x0008BB08 File Offset: 0x00089D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060037D5 RID: 14293 RVA: 0x0008BB0B File Offset: 0x00089D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtVarUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x0008BB12 File Offset: 0x00089D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtVarUpdateNotify()
		{
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x0008BB28 File Offset: 0x00089D28
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

		// Token: 0x060037D8 RID: 14296 RVA: 0x0008BB8C File Offset: 0x00089D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtVarUpdateNotify Clone()
		{
			return new BtVarUpdateNotify(this);
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060037D9 RID: 14297 RVA: 0x0008BB94 File Offset: 0x00089D94
		// (set) Token: 0x060037DA RID: 14298 RVA: 0x0008BB9C File Offset: 0x00089D9C
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

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x060037DB RID: 14299 RVA: 0x0008BBA5 File Offset: 0x00089DA5
		// (set) Token: 0x060037DC RID: 14300 RVA: 0x0008BBAD File Offset: 0x00089DAD
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

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x060037DD RID: 14301 RVA: 0x0008BBB6 File Offset: 0x00089DB6
		// (set) Token: 0x060037DE RID: 14302 RVA: 0x0008BBBE File Offset: 0x00089DBE
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

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x060037DF RID: 14303 RVA: 0x0008BBD1 File Offset: 0x00089DD1
		// (set) Token: 0x060037E0 RID: 14304 RVA: 0x0008BBD9 File Offset: 0x00089DD9
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

		// Token: 0x060037E1 RID: 14305 RVA: 0x0008BBE2 File Offset: 0x00089DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtVarUpdateNotify);
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x0008BBF0 File Offset: 0x00089DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtVarUpdateNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && !(this.VarName != other.VarName) && object.Equals(this.VarDefine, other.VarDefine) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x0008BC64 File Offset: 0x00089E64
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

		// Token: 0x060037E4 RID: 14308 RVA: 0x0008BCED File Offset: 0x00089EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x0008BCFA File Offset: 0x00089EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x0008BD04 File Offset: 0x00089F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VarName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.VarName);
			}
			if (this.varDefine_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.VarDefine);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x0008BD9C File Offset: 0x00089F9C
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

		// Token: 0x060037E8 RID: 14312 RVA: 0x0008BE28 File Offset: 0x0008A028
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

		// Token: 0x060037E9 RID: 14313 RVA: 0x0008BEBD File Offset: 0x0008A0BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x0008BEC8 File Offset: 0x0008A0C8
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
				if (num <= 26U)
				{
					if (num == 10U)
					{
						this.VarName = input.ReadString();
						continue;
					}
					if (num == 26U)
					{
						if (this.varDefine_ == null)
						{
							this.VarDefine = new VarDefinePb();
						}
						input.ReadMessage(this.VarDefine);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B09 RID: 11017
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B0A RID: 11018
		public const int TreeOwnerIdFieldNumber = 15;

		// Token: 0x04002B0B RID: 11019
		private int treeOwnerId_;

		// Token: 0x04002B0C RID: 11020
		public const int TreeIncIdFieldNumber = 8;

		// Token: 0x04002B0D RID: 11021
		private long treeIncId_;

		// Token: 0x04002B0E RID: 11022
		public const int VarNameFieldNumber = 1;

		// Token: 0x04002B0F RID: 11023
		private string varName_ = "";

		// Token: 0x04002B10 RID: 11024
		public const int VarDefineFieldNumber = 3;

		// Token: 0x04002B11 RID: 11025
		private VarDefinePb varDefine_;
	}
}
