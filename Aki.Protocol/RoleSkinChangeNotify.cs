using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A9 RID: 4265
	[NetMessage(EMessageId.RoleSkinChangeNotify)]
	public sealed class RoleSkinChangeNotify : IMessage<RoleSkinChangeNotify>, IMessage, IEquatable<RoleSkinChangeNotify>, IDeepCloneable<RoleSkinChangeNotify>, IBufferMessage
	{
		// Token: 0x06016CC4 RID: 93380 RVA: 0x003507A5 File Offset: 0x0034E9A5
		[NullableContext(1)]
		public static RoleSkinChangeNotify Create()
		{
			return new RoleSkinChangeNotify();
		}

		// Token: 0x17004C68 RID: 19560
		// (get) Token: 0x06016CC5 RID: 93381 RVA: 0x003507AC File Offset: 0x0034E9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C69 RID: 19561
		// (get) Token: 0x06016CC6 RID: 93382 RVA: 0x003507AF File Offset: 0x0034E9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinChangeNotify.Descriptor;
			}
		}

		// Token: 0x06016CC7 RID: 93383 RVA: 0x003507B6 File Offset: 0x0034E9B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeNotify()
		{
		}

		// Token: 0x06016CC8 RID: 93384 RVA: 0x003507BE File Offset: 0x0034E9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeNotify(RoleSkinChangeNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016CC9 RID: 93385 RVA: 0x003507EF File Offset: 0x0034E9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeNotify Clone()
		{
			return new RoleSkinChangeNotify(this);
		}

		// Token: 0x17004C6A RID: 19562
		// (get) Token: 0x06016CCA RID: 93386 RVA: 0x003507F7 File Offset: 0x0034E9F7
		// (set) Token: 0x06016CCB RID: 93387 RVA: 0x003507FF File Offset: 0x0034E9FF
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

		// Token: 0x17004C6B RID: 19563
		// (get) Token: 0x06016CCC RID: 93388 RVA: 0x00350808 File Offset: 0x0034EA08
		// (set) Token: 0x06016CCD RID: 93389 RVA: 0x00350810 File Offset: 0x0034EA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x06016CCE RID: 93390 RVA: 0x00350819 File Offset: 0x0034EA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinChangeNotify);
		}

		// Token: 0x06016CCF RID: 93391 RVA: 0x00350827 File Offset: 0x0034EA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinChangeNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016CD0 RID: 93392 RVA: 0x00350868 File Offset: 0x0034EA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016CD1 RID: 93393 RVA: 0x003508C0 File Offset: 0x0034EAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016CD2 RID: 93394 RVA: 0x003508CD File Offset: 0x0034EACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016CD3 RID: 93395 RVA: 0x003508D8 File Offset: 0x0034EAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this.SkinId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016CD4 RID: 93396 RVA: 0x00350934 File Offset: 0x0034EB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016CD5 RID: 93397 RVA: 0x0035098C File Offset: 0x0034EB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016CD6 RID: 93398 RVA: 0x003509DC File Offset: 0x0034EBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016CD7 RID: 93399 RVA: 0x003509E8 File Offset: 0x0034EBE8
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkinId = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008881 RID: 34945
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008882 RID: 34946
		public const int RoleIdFieldNumber = 2;

		// Token: 0x04008883 RID: 34947
		private int roleId_;

		// Token: 0x04008884 RID: 34948
		public const int SkinIdFieldNumber = 13;

		// Token: 0x04008885 RID: 34949
		private int skinId_;
	}
}
