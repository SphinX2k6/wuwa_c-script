using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001466 RID: 5222
	public sealed class TrialRoleItem : IMessage<TrialRoleItem>, IMessage, IEquatable<TrialRoleItem>, IDeepCloneable<TrialRoleItem>, IBufferMessage
	{
		// Token: 0x0601BA69 RID: 113257 RVA: 0x00400B41 File Offset: 0x003FED41
		[NullableContext(1)]
		public static TrialRoleItem Create()
		{
			return new TrialRoleItem();
		}

		// Token: 0x17005D42 RID: 23874
		// (get) Token: 0x0601BA6A RID: 113258 RVA: 0x00400B48 File Offset: 0x003FED48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrialRoleItem> Parser
		{
			get
			{
				return TrialRoleItem._parser;
			}
		}

		// Token: 0x17005D43 RID: 23875
		// (get) Token: 0x0601BA6B RID: 113259 RVA: 0x00400B4F File Offset: 0x003FED4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D44 RID: 23876
		// (get) Token: 0x0601BA6C RID: 113260 RVA: 0x00400B52 File Offset: 0x003FED52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrialRoleItem.Descriptor;
			}
		}

		// Token: 0x0601BA6D RID: 113261 RVA: 0x00400B59 File Offset: 0x003FED59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleItem()
		{
		}

		// Token: 0x0601BA6E RID: 113262 RVA: 0x00400B61 File Offset: 0x003FED61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleItem(TrialRoleItem other) : this()
		{
			this.roleId_ = other.roleId_;
			this.show_ = other.show_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BA6F RID: 113263 RVA: 0x00400B92 File Offset: 0x003FED92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrialRoleItem Clone()
		{
			return new TrialRoleItem(this);
		}

		// Token: 0x17005D45 RID: 23877
		// (get) Token: 0x0601BA70 RID: 113264 RVA: 0x00400B9A File Offset: 0x003FED9A
		// (set) Token: 0x0601BA71 RID: 113265 RVA: 0x00400BA2 File Offset: 0x003FEDA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17005D46 RID: 23878
		// (get) Token: 0x0601BA72 RID: 113266 RVA: 0x00400BAB File Offset: 0x003FEDAB
		// (set) Token: 0x0601BA73 RID: 113267 RVA: 0x00400BB3 File Offset: 0x003FEDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Show
		{
			get
			{
				return this.show_;
			}
			set
			{
				this.show_ = value;
			}
		}

		// Token: 0x0601BA74 RID: 113268 RVA: 0x00400BBC File Offset: 0x003FEDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrialRoleItem);
		}

		// Token: 0x0601BA75 RID: 113269 RVA: 0x00400BCA File Offset: 0x003FEDCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrialRoleItem other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Show == other.Show && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BA76 RID: 113270 RVA: 0x00400C08 File Offset: 0x003FEE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Show)
			{
				num ^= this.Show.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BA77 RID: 113271 RVA: 0x00400C60 File Offset: 0x003FEE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BA78 RID: 113272 RVA: 0x00400C6D File Offset: 0x003FEE6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BA79 RID: 113273 RVA: 0x00400C78 File Offset: 0x003FEE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Show)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Show);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BA7A RID: 113274 RVA: 0x00400CD0 File Offset: 0x003FEED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Show)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BA7B RID: 113275 RVA: 0x00400D1C File Offset: 0x003FEF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrialRoleItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Show)
			{
				this.Show = other.Show;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BA7C RID: 113276 RVA: 0x00400D6C File Offset: 0x003FEF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BA7D RID: 113277 RVA: 0x00400D78 File Offset: 0x003FEF78
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Show = input.ReadBool();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009F63 RID: 40803
		private static readonly MessageParser<TrialRoleItem> _parser = new MessageParser<TrialRoleItem>(() => new TrialRoleItem());

		// Token: 0x04009F64 RID: 40804
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F65 RID: 40805
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04009F66 RID: 40806
		private int roleId_;

		// Token: 0x04009F67 RID: 40807
		public const int ShowFieldNumber = 2;

		// Token: 0x04009F68 RID: 40808
		private bool show_;
	}
}
