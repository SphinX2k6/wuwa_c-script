using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D28 RID: 3368
	public sealed class PhotoFightCtx : IMessage<PhotoFightCtx>, IMessage, IEquatable<PhotoFightCtx>, IDeepCloneable<PhotoFightCtx>, IBufferMessage
	{
		// Token: 0x060122F9 RID: 74489 RVA: 0x002A7EC0 File Offset: 0x002A60C0
		[NullableContext(1)]
		public static PhotoFightCtx Create()
		{
			return new PhotoFightCtx();
		}

		// Token: 0x17003C41 RID: 15425
		// (get) Token: 0x060122FA RID: 74490 RVA: 0x002A7EC7 File Offset: 0x002A60C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C42 RID: 15426
		// (get) Token: 0x060122FB RID: 74491 RVA: 0x002A7ECA File Offset: 0x002A60CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightCtx.Descriptor;
			}
		}

		// Token: 0x060122FC RID: 74492 RVA: 0x002A7ED1 File Offset: 0x002A60D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightCtx()
		{
		}

		// Token: 0x060122FD RID: 74493 RVA: 0x002A7ED9 File Offset: 0x002A60D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightCtx(PhotoFightCtx other) : this()
		{
			this.activityId_ = other.activityId_;
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060122FE RID: 74494 RVA: 0x002A7F0A File Offset: 0x002A610A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightCtx Clone()
		{
			return new PhotoFightCtx(this);
		}

		// Token: 0x17003C43 RID: 15427
		// (get) Token: 0x060122FF RID: 74495 RVA: 0x002A7F12 File Offset: 0x002A6112
		// (set) Token: 0x06012300 RID: 74496 RVA: 0x002A7F1A File Offset: 0x002A611A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17003C44 RID: 15428
		// (get) Token: 0x06012301 RID: 74497 RVA: 0x002A7F23 File Offset: 0x002A6123
		// (set) Token: 0x06012302 RID: 74498 RVA: 0x002A7F2B File Offset: 0x002A612B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x06012303 RID: 74499 RVA: 0x002A7F34 File Offset: 0x002A6134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightCtx);
		}

		// Token: 0x06012304 RID: 74500 RVA: 0x002A7F42 File Offset: 0x002A6142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightCtx other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012305 RID: 74501 RVA: 0x002A7F80 File Offset: 0x002A6180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012306 RID: 74502 RVA: 0x002A7FD8 File Offset: 0x002A61D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012307 RID: 74503 RVA: 0x002A7FE5 File Offset: 0x002A61E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012308 RID: 74504 RVA: 0x002A7FF0 File Offset: 0x002A61F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LevelId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012309 RID: 74505 RVA: 0x002A8048 File Offset: 0x002A6248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601230A RID: 74506 RVA: 0x002A80A0 File Offset: 0x002A62A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoFightCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601230B RID: 74507 RVA: 0x002A80F0 File Offset: 0x002A62F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601230C RID: 74508 RVA: 0x002A80FC File Offset: 0x002A62FC
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
						this.LevelId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007193 RID: 29075
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007194 RID: 29076
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04007195 RID: 29077
		private int activityId_;

		// Token: 0x04007196 RID: 29078
		public const int LevelIdFieldNumber = 2;

		// Token: 0x04007197 RID: 29079
		private int levelId_;
	}
}
