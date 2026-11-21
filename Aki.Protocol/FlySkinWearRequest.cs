using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005FE RID: 1534
	[NetMessage(EMessageId.FlySkinWearRequest)]
	public sealed class FlySkinWearRequest : IMessage<FlySkinWearRequest>, IMessage, IEquatable<FlySkinWearRequest>, IDeepCloneable<FlySkinWearRequest>, IBufferMessage
	{
		// Token: 0x06008E3A RID: 36410 RVA: 0x00159154 File Offset: 0x00157354
		[NullableContext(1)]
		public static FlySkinWearRequest Create()
		{
			return new FlySkinWearRequest();
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x06008E3B RID: 36411 RVA: 0x0015915B File Offset: 0x0015735B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x06008E3C RID: 36412 RVA: 0x0015915E File Offset: 0x0015735E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinWearRequest.Descriptor;
			}
		}

		// Token: 0x06008E3D RID: 36413 RVA: 0x00159165 File Offset: 0x00157365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearRequest()
		{
		}

		// Token: 0x06008E3E RID: 36414 RVA: 0x0015916D File Offset: 0x0015736D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearRequest(FlySkinWearRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E3F RID: 36415 RVA: 0x0015919E File Offset: 0x0015739E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearRequest Clone()
		{
			return new FlySkinWearRequest(this);
		}

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x06008E40 RID: 36416 RVA: 0x001591A6 File Offset: 0x001573A6
		// (set) Token: 0x06008E41 RID: 36417 RVA: 0x001591AE File Offset: 0x001573AE
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

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x06008E42 RID: 36418 RVA: 0x001591B7 File Offset: 0x001573B7
		// (set) Token: 0x06008E43 RID: 36419 RVA: 0x001591BF File Offset: 0x001573BF
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

		// Token: 0x06008E44 RID: 36420 RVA: 0x001591C8 File Offset: 0x001573C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinWearRequest);
		}

		// Token: 0x06008E45 RID: 36421 RVA: 0x001591D6 File Offset: 0x001573D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinWearRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E46 RID: 36422 RVA: 0x00159214 File Offset: 0x00157414
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

		// Token: 0x06008E47 RID: 36423 RVA: 0x0015926C File Offset: 0x0015746C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008E48 RID: 36424 RVA: 0x00159279 File Offset: 0x00157479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E49 RID: 36425 RVA: 0x00159284 File Offset: 0x00157484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkinId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E4A RID: 36426 RVA: 0x001592DC File Offset: 0x001574DC
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

		// Token: 0x06008E4B RID: 36427 RVA: 0x00159334 File Offset: 0x00157534
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

		// Token: 0x06008E4C RID: 36428 RVA: 0x00159384 File Offset: 0x00157584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E4D RID: 36429 RVA: 0x00159390 File Offset: 0x00157590
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040045A6 RID: 17830
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045A7 RID: 17831
		public const int RoleIdFieldNumber = 8;

		// Token: 0x040045A8 RID: 17832
		private int roleId_;

		// Token: 0x040045A9 RID: 17833
		public const int SkinIdFieldNumber = 1;

		// Token: 0x040045AA RID: 17834
		private int skinId_;
	}
}
