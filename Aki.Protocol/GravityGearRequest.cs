using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006FE RID: 1790
	[NetMessage(EMessageId.GravityGearRequest)]
	public sealed class GravityGearRequest : IMessage<GravityGearRequest>, IMessage, IEquatable<GravityGearRequest>, IDeepCloneable<GravityGearRequest>, IBufferMessage
	{
		// Token: 0x0600A342 RID: 41794 RVA: 0x0018AA80 File Offset: 0x00188C80
		[NullableContext(1)]
		public static GravityGearRequest Create()
		{
			return new GravityGearRequest();
		}

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x0600A343 RID: 41795 RVA: 0x0018AA87 File Offset: 0x00188C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x0600A344 RID: 41796 RVA: 0x0018AA8A File Offset: 0x00188C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityGearRequest.Descriptor;
			}
		}

		// Token: 0x0600A345 RID: 41797 RVA: 0x0018AA91 File Offset: 0x00188C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityGearRequest()
		{
		}

		// Token: 0x0600A346 RID: 41798 RVA: 0x0018AA99 File Offset: 0x00188C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityGearRequest(GravityGearRequest other) : this()
		{
			this.entityConfId_ = other.entityConfId_;
			this.gravityGearOperate_ = other.gravityGearOperate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A347 RID: 41799 RVA: 0x0018AACA File Offset: 0x00188CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityGearRequest Clone()
		{
			return new GravityGearRequest(this);
		}

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x0600A348 RID: 41800 RVA: 0x0018AAD2 File Offset: 0x00188CD2
		// (set) Token: 0x0600A349 RID: 41801 RVA: 0x0018AADA File Offset: 0x00188CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfId
		{
			get
			{
				return this.entityConfId_;
			}
			set
			{
				this.entityConfId_ = value;
			}
		}

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x0600A34A RID: 41802 RVA: 0x0018AAE3 File Offset: 0x00188CE3
		// (set) Token: 0x0600A34B RID: 41803 RVA: 0x0018AAEB File Offset: 0x00188CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityGearOperate GravityGearOperate
		{
			get
			{
				return this.gravityGearOperate_;
			}
			set
			{
				this.gravityGearOperate_ = value;
			}
		}

		// Token: 0x0600A34C RID: 41804 RVA: 0x0018AAF4 File Offset: 0x00188CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityGearRequest);
		}

		// Token: 0x0600A34D RID: 41805 RVA: 0x0018AB02 File Offset: 0x00188D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityGearRequest other)
		{
			return other != null && (other == this || (this.EntityConfId == other.EntityConfId && this.GravityGearOperate == other.GravityGearOperate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A34E RID: 41806 RVA: 0x0018AB40 File Offset: 0x00188D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityConfId != 0)
			{
				num ^= this.EntityConfId.GetHashCode();
			}
			if (this.GravityGearOperate != GravityGearOperate.InActive)
			{
				num ^= this.GravityGearOperate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A34F RID: 41807 RVA: 0x0018AB9E File Offset: 0x00188D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A350 RID: 41808 RVA: 0x0018ABAB File Offset: 0x00188DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A351 RID: 41809 RVA: 0x0018ABB4 File Offset: 0x00188DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GravityGearOperate != GravityGearOperate.InActive)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.GravityGearOperate);
			}
			if (this.EntityConfId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.EntityConfId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A352 RID: 41810 RVA: 0x0018AC10 File Offset: 0x00188E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfId);
			}
			if (this.GravityGearOperate != GravityGearOperate.InActive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GravityGearOperate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A353 RID: 41811 RVA: 0x0018AC68 File Offset: 0x00188E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GravityGearRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityConfId != 0)
			{
				this.EntityConfId = other.EntityConfId;
			}
			if (other.GravityGearOperate != GravityGearOperate.InActive)
			{
				this.GravityGearOperate = other.GravityGearOperate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A354 RID: 41812 RVA: 0x0018ACB8 File Offset: 0x00188EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A355 RID: 41813 RVA: 0x0018ACC4 File Offset: 0x00188EC4
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityConfId = input.ReadInt32();
					}
				}
				else
				{
					this.GravityGearOperate = (GravityGearOperate)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004BCF RID: 19407
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BD0 RID: 19408
		public const int EntityConfIdFieldNumber = 14;

		// Token: 0x04004BD1 RID: 19409
		private int entityConfId_;

		// Token: 0x04004BD2 RID: 19410
		public const int GravityGearOperateFieldNumber = 2;

		// Token: 0x04004BD3 RID: 19411
		private GravityGearOperate gravityGearOperate_;
	}
}
