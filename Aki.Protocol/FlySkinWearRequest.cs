using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000613 RID: 1555
	[NetMessage(EMessageId.FlySkinWearRequest)]
	public sealed class FlySkinWearRequest : IMessage<FlySkinWearRequest>, IMessage, IEquatable<FlySkinWearRequest>, IDeepCloneable<FlySkinWearRequest>, IBufferMessage
	{
		// Token: 0x06008FA2 RID: 36770 RVA: 0x0015BD58 File Offset: 0x00159F58
		[NullableContext(1)]
		public static FlySkinWearRequest Create()
		{
			return new FlySkinWearRequest();
		}

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x06008FA3 RID: 36771 RVA: 0x0015BD5F File Offset: 0x00159F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x06008FA4 RID: 36772 RVA: 0x0015BD62 File Offset: 0x00159F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinWearRequest.Descriptor;
			}
		}

		// Token: 0x06008FA5 RID: 36773 RVA: 0x0015BD69 File Offset: 0x00159F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearRequest()
		{
		}

		// Token: 0x06008FA6 RID: 36774 RVA: 0x0015BD71 File Offset: 0x00159F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearRequest(FlySkinWearRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FA7 RID: 36775 RVA: 0x0015BDA2 File Offset: 0x00159FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearRequest Clone()
		{
			return new FlySkinWearRequest(this);
		}

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x06008FA8 RID: 36776 RVA: 0x0015BDAA File Offset: 0x00159FAA
		// (set) Token: 0x06008FA9 RID: 36777 RVA: 0x0015BDB2 File Offset: 0x00159FB2
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

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x06008FAA RID: 36778 RVA: 0x0015BDBB File Offset: 0x00159FBB
		// (set) Token: 0x06008FAB RID: 36779 RVA: 0x0015BDC3 File Offset: 0x00159FC3
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

		// Token: 0x06008FAC RID: 36780 RVA: 0x0015BDCC File Offset: 0x00159FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinWearRequest);
		}

		// Token: 0x06008FAD RID: 36781 RVA: 0x0015BDDA File Offset: 0x00159FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinWearRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008FAE RID: 36782 RVA: 0x0015BE18 File Offset: 0x0015A018
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

		// Token: 0x06008FAF RID: 36783 RVA: 0x0015BE70 File Offset: 0x0015A070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008FB0 RID: 36784 RVA: 0x0015BE7D File Offset: 0x0015A07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FB1 RID: 36785 RVA: 0x0015BE88 File Offset: 0x0015A088
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
				output.WriteRawTag(40);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FB2 RID: 36786 RVA: 0x0015BEE4 File Offset: 0x0015A0E4
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

		// Token: 0x06008FB3 RID: 36787 RVA: 0x0015BF3C File Offset: 0x0015A13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinWearRequest other)
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

		// Token: 0x06008FB4 RID: 36788 RVA: 0x0015BF8C File Offset: 0x0015A18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FB5 RID: 36789 RVA: 0x0015BF98 File Offset: 0x0015A198
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

		// Token: 0x040045B0 RID: 17840
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045B1 RID: 17841
		public const int RoleIdFieldNumber = 2;

		// Token: 0x040045B2 RID: 17842
		private int roleId_;

		// Token: 0x040045B3 RID: 17843
		public const int SkinIdFieldNumber = 5;

		// Token: 0x040045B4 RID: 17844
		private int skinId_;
	}
}
