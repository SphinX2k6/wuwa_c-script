using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D18 RID: 3352
	public sealed class PhotoFightCtx : IMessage<PhotoFightCtx>, IMessage, IEquatable<PhotoFightCtx>, IDeepCloneable<PhotoFightCtx>, IBufferMessage
	{
		// Token: 0x060121FD RID: 74237 RVA: 0x002A629C File Offset: 0x002A449C
		[NullableContext(1)]
		public static PhotoFightCtx Create()
		{
			return new PhotoFightCtx();
		}

		// Token: 0x17003C0C RID: 15372
		// (get) Token: 0x060121FE RID: 74238 RVA: 0x002A62A3 File Offset: 0x002A44A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C0D RID: 15373
		// (get) Token: 0x060121FF RID: 74239 RVA: 0x002A62A6 File Offset: 0x002A44A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightCtx.Descriptor;
			}
		}

		// Token: 0x06012200 RID: 74240 RVA: 0x002A62AD File Offset: 0x002A44AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightCtx()
		{
		}

		// Token: 0x06012201 RID: 74241 RVA: 0x002A62B5 File Offset: 0x002A44B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightCtx(PhotoFightCtx other) : this()
		{
			this.activityId_ = other.activityId_;
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012202 RID: 74242 RVA: 0x002A62E6 File Offset: 0x002A44E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightCtx Clone()
		{
			return new PhotoFightCtx(this);
		}

		// Token: 0x17003C0E RID: 15374
		// (get) Token: 0x06012203 RID: 74243 RVA: 0x002A62EE File Offset: 0x002A44EE
		// (set) Token: 0x06012204 RID: 74244 RVA: 0x002A62F6 File Offset: 0x002A44F6
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

		// Token: 0x17003C0F RID: 15375
		// (get) Token: 0x06012205 RID: 74245 RVA: 0x002A62FF File Offset: 0x002A44FF
		// (set) Token: 0x06012206 RID: 74246 RVA: 0x002A6307 File Offset: 0x002A4507
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

		// Token: 0x06012207 RID: 74247 RVA: 0x002A6310 File Offset: 0x002A4510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightCtx);
		}

		// Token: 0x06012208 RID: 74248 RVA: 0x002A631E File Offset: 0x002A451E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightCtx other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012209 RID: 74249 RVA: 0x002A635C File Offset: 0x002A455C
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

		// Token: 0x0601220A RID: 74250 RVA: 0x002A63B4 File Offset: 0x002A45B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601220B RID: 74251 RVA: 0x002A63C1 File Offset: 0x002A45C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601220C RID: 74252 RVA: 0x002A63CC File Offset: 0x002A45CC
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

		// Token: 0x0601220D RID: 74253 RVA: 0x002A6424 File Offset: 0x002A4624
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

		// Token: 0x0601220E RID: 74254 RVA: 0x002A647C File Offset: 0x002A467C
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

		// Token: 0x0601220F RID: 74255 RVA: 0x002A64CC File Offset: 0x002A46CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012210 RID: 74256 RVA: 0x002A64D8 File Offset: 0x002A46D8
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

		// Token: 0x040071AB RID: 29099
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071AC RID: 29100
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x040071AD RID: 29101
		private int activityId_;

		// Token: 0x040071AE RID: 29102
		public const int LevelIdFieldNumber = 2;

		// Token: 0x040071AF RID: 29103
		private int levelId_;
	}
}
