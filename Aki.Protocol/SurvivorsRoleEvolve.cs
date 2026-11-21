using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001350 RID: 4944
	public sealed class SurvivorsRoleEvolve : IMessage<SurvivorsRoleEvolve>, IMessage, IEquatable<SurvivorsRoleEvolve>, IDeepCloneable<SurvivorsRoleEvolve>, IBufferMessage
	{
		// Token: 0x0601A588 RID: 107912 RVA: 0x003D724D File Offset: 0x003D544D
		[NullableContext(1)]
		public static SurvivorsRoleEvolve Create()
		{
			return new SurvivorsRoleEvolve();
		}

		// Token: 0x1700593B RID: 22843
		// (get) Token: 0x0601A589 RID: 107913 RVA: 0x003D7254 File Offset: 0x003D5454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700593C RID: 22844
		// (get) Token: 0x0601A58A RID: 107914 RVA: 0x003D7257 File Offset: 0x003D5457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsRoleEvolve.Descriptor;
			}
		}

		// Token: 0x0601A58B RID: 107915 RVA: 0x003D725E File Offset: 0x003D545E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleEvolve()
		{
		}

		// Token: 0x0601A58C RID: 107916 RVA: 0x003D7266 File Offset: 0x003D5466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleEvolve(SurvivorsRoleEvolve other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A58D RID: 107917 RVA: 0x003D728B File Offset: 0x003D548B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleEvolve Clone()
		{
			return new SurvivorsRoleEvolve(this);
		}

		// Token: 0x1700593D RID: 22845
		// (get) Token: 0x0601A58E RID: 107918 RVA: 0x003D7293 File Offset: 0x003D5493
		// (set) Token: 0x0601A58F RID: 107919 RVA: 0x003D729B File Offset: 0x003D549B
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

		// Token: 0x0601A590 RID: 107920 RVA: 0x003D72A4 File Offset: 0x003D54A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsRoleEvolve);
		}

		// Token: 0x0601A591 RID: 107921 RVA: 0x003D72B2 File Offset: 0x003D54B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsRoleEvolve other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A592 RID: 107922 RVA: 0x003D72E0 File Offset: 0x003D54E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A593 RID: 107923 RVA: 0x003D731F File Offset: 0x003D551F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A594 RID: 107924 RVA: 0x003D732C File Offset: 0x003D552C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A595 RID: 107925 RVA: 0x003D7335 File Offset: 0x003D5535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A596 RID: 107926 RVA: 0x003D7368 File Offset: 0x003D5568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A597 RID: 107927 RVA: 0x003D73A6 File Offset: 0x003D55A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsRoleEvolve other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A598 RID: 107928 RVA: 0x003D73D7 File Offset: 0x003D55D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A599 RID: 107929 RVA: 0x003D73E0 File Offset: 0x003D55E0
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
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009ACF RID: 39631
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AD0 RID: 39632
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04009AD1 RID: 39633
		private int roleId_;
	}
}
