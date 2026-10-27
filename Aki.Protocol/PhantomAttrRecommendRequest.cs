using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C18 RID: 3096
	[NetMessage(EMessageId.PhantomAttrRecommendRequest)]
	public sealed class PhantomAttrRecommendRequest : IMessage<PhantomAttrRecommendRequest>, IMessage, IEquatable<PhantomAttrRecommendRequest>, IDeepCloneable<PhantomAttrRecommendRequest>, IBufferMessage
	{
		// Token: 0x06010CE9 RID: 68841 RVA: 0x00276282 File Offset: 0x00274482
		[NullableContext(1)]
		public static PhantomAttrRecommendRequest Create()
		{
			return new PhantomAttrRecommendRequest();
		}

		// Token: 0x1700377B RID: 14203
		// (get) Token: 0x06010CEA RID: 68842 RVA: 0x00276289 File Offset: 0x00274489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x06010CEB RID: 68843 RVA: 0x0027628C File Offset: 0x0027448C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomAttrRecommendRequest.Descriptor;
			}
		}

		// Token: 0x06010CEC RID: 68844 RVA: 0x00276293 File Offset: 0x00274493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendRequest()
		{
		}

		// Token: 0x06010CED RID: 68845 RVA: 0x0027629B File Offset: 0x0027449B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendRequest(PhantomAttrRecommendRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010CEE RID: 68846 RVA: 0x002762C0 File Offset: 0x002744C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAttrRecommendRequest Clone()
		{
			return new PhantomAttrRecommendRequest(this);
		}

		// Token: 0x1700377D RID: 14205
		// (get) Token: 0x06010CEF RID: 68847 RVA: 0x002762C8 File Offset: 0x002744C8
		// (set) Token: 0x06010CF0 RID: 68848 RVA: 0x002762D0 File Offset: 0x002744D0
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

		// Token: 0x06010CF1 RID: 68849 RVA: 0x002762D9 File Offset: 0x002744D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomAttrRecommendRequest);
		}

		// Token: 0x06010CF2 RID: 68850 RVA: 0x002762E7 File Offset: 0x002744E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomAttrRecommendRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010CF3 RID: 68851 RVA: 0x00276318 File Offset: 0x00274518
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

		// Token: 0x06010CF4 RID: 68852 RVA: 0x00276357 File Offset: 0x00274557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010CF5 RID: 68853 RVA: 0x00276364 File Offset: 0x00274564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010CF6 RID: 68854 RVA: 0x0027636D File Offset: 0x0027456D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010CF7 RID: 68855 RVA: 0x002763A0 File Offset: 0x002745A0
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

		// Token: 0x06010CF8 RID: 68856 RVA: 0x002763DE File Offset: 0x002745DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomAttrRecommendRequest other)
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

		// Token: 0x06010CF9 RID: 68857 RVA: 0x0027640F File Offset: 0x0027460F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010CFA RID: 68858 RVA: 0x00276418 File Offset: 0x00274618
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006ABA RID: 27322
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006ABB RID: 27323
		public const int RoleIdFieldNumber = 14;

		// Token: 0x04006ABC RID: 27324
		private int roleId_;
	}
}
