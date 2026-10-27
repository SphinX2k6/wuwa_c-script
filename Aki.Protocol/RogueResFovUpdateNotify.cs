using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FDD RID: 4061
	[NetMessage(EMessageId.RogueResFovUpdateNotify)]
	public sealed class RogueResFovUpdateNotify : IMessage<RogueResFovUpdateNotify>, IMessage, IEquatable<RogueResFovUpdateNotify>, IDeepCloneable<RogueResFovUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015B3B RID: 88891 RVA: 0x003262C5 File Offset: 0x003244C5
		[NullableContext(1)]
		public static RogueResFovUpdateNotify Create()
		{
			return new RogueResFovUpdateNotify();
		}

		// Token: 0x1700485F RID: 18527
		// (get) Token: 0x06015B3C RID: 88892 RVA: 0x003262CC File Offset: 0x003244CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004860 RID: 18528
		// (get) Token: 0x06015B3D RID: 88893 RVA: 0x003262CF File Offset: 0x003244CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResFovUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015B3E RID: 88894 RVA: 0x003262D6 File Offset: 0x003244D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFovUpdateNotify()
		{
		}

		// Token: 0x06015B3F RID: 88895 RVA: 0x003262DE File Offset: 0x003244DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFovUpdateNotify(RogueResFovUpdateNotify other) : this()
		{
			this.fov_ = other.fov_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015B40 RID: 88896 RVA: 0x00326303 File Offset: 0x00324503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFovUpdateNotify Clone()
		{
			return new RogueResFovUpdateNotify(this);
		}

		// Token: 0x17004861 RID: 18529
		// (get) Token: 0x06015B41 RID: 88897 RVA: 0x0032630B File Offset: 0x0032450B
		// (set) Token: 0x06015B42 RID: 88898 RVA: 0x00326313 File Offset: 0x00324513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Fov
		{
			get
			{
				return this.fov_;
			}
			set
			{
				this.fov_ = value;
			}
		}

		// Token: 0x06015B43 RID: 88899 RVA: 0x0032631C File Offset: 0x0032451C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResFovUpdateNotify);
		}

		// Token: 0x06015B44 RID: 88900 RVA: 0x0032632A File Offset: 0x0032452A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResFovUpdateNotify other)
		{
			return other != null && (other == this || (this.Fov == other.Fov && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015B45 RID: 88901 RVA: 0x00326358 File Offset: 0x00324558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Fov != 0)
			{
				num ^= this.Fov.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015B46 RID: 88902 RVA: 0x00326397 File Offset: 0x00324597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015B47 RID: 88903 RVA: 0x003263A4 File Offset: 0x003245A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015B48 RID: 88904 RVA: 0x003263AD File Offset: 0x003245AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Fov != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Fov);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015B49 RID: 88905 RVA: 0x003263E0 File Offset: 0x003245E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Fov != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Fov);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015B4A RID: 88906 RVA: 0x0032641E File Offset: 0x0032461E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResFovUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Fov != 0)
			{
				this.Fov = other.Fov;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015B4B RID: 88907 RVA: 0x0032644F File Offset: 0x0032464F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015B4C RID: 88908 RVA: 0x00326458 File Offset: 0x00324658
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Fov = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400823A RID: 33338
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400823B RID: 33339
		public const int FovFieldNumber = 3;

		// Token: 0x0400823C RID: 33340
		private int fov_;
	}
}
