using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE6 RID: 2790
	[NetMessage(EMessageId.NewbieAdventureChapterDropRequest)]
	public sealed class NewbieAdventureChapterDropRequest : IMessage<NewbieAdventureChapterDropRequest>, IMessage, IEquatable<NewbieAdventureChapterDropRequest>, IDeepCloneable<NewbieAdventureChapterDropRequest>, IBufferMessage
	{
		// Token: 0x0600F2F9 RID: 62201 RVA: 0x00238168 File Offset: 0x00236368
		[NullableContext(1)]
		public static NewbieAdventureChapterDropRequest Create()
		{
			return new NewbieAdventureChapterDropRequest();
		}

		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x0600F2FA RID: 62202 RVA: 0x0023816F File Offset: 0x0023636F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x0600F2FB RID: 62203 RVA: 0x00238172 File Offset: 0x00236372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieAdventureChapterDropRequest.Descriptor;
			}
		}

		// Token: 0x0600F2FC RID: 62204 RVA: 0x00238179 File Offset: 0x00236379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureChapterDropRequest()
		{
		}

		// Token: 0x0600F2FD RID: 62205 RVA: 0x00238181 File Offset: 0x00236381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureChapterDropRequest(NewbieAdventureChapterDropRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.chapterId_ = other.chapterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F2FE RID: 62206 RVA: 0x002381B2 File Offset: 0x002363B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieAdventureChapterDropRequest Clone()
		{
			return new NewbieAdventureChapterDropRequest(this);
		}

		// Token: 0x1700317C RID: 12668
		// (get) Token: 0x0600F2FF RID: 62207 RVA: 0x002381BA File Offset: 0x002363BA
		// (set) Token: 0x0600F300 RID: 62208 RVA: 0x002381C2 File Offset: 0x002363C2
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

		// Token: 0x1700317D RID: 12669
		// (get) Token: 0x0600F301 RID: 62209 RVA: 0x002381CB File Offset: 0x002363CB
		// (set) Token: 0x0600F302 RID: 62210 RVA: 0x002381D3 File Offset: 0x002363D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChapterId
		{
			get
			{
				return this.chapterId_;
			}
			set
			{
				this.chapterId_ = value;
			}
		}

		// Token: 0x0600F303 RID: 62211 RVA: 0x002381DC File Offset: 0x002363DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieAdventureChapterDropRequest);
		}

		// Token: 0x0600F304 RID: 62212 RVA: 0x002381EA File Offset: 0x002363EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieAdventureChapterDropRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ChapterId == other.ChapterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F305 RID: 62213 RVA: 0x00238228 File Offset: 0x00236428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.ChapterId != 0)
			{
				num ^= this.ChapterId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F306 RID: 62214 RVA: 0x00238280 File Offset: 0x00236480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F307 RID: 62215 RVA: 0x0023828D File Offset: 0x0023648D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F308 RID: 62216 RVA: 0x00238298 File Offset: 0x00236498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ChapterId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ChapterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F309 RID: 62217 RVA: 0x002382F4 File Offset: 0x002364F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.ChapterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChapterId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F30A RID: 62218 RVA: 0x0023834C File Offset: 0x0023654C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieAdventureChapterDropRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.ChapterId != 0)
			{
				this.ChapterId = other.ChapterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F30B RID: 62219 RVA: 0x0023839C File Offset: 0x0023659C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F30C RID: 62220 RVA: 0x002383A8 File Offset: 0x002365A8
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChapterId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400625E RID: 25182
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400625F RID: 25183
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04006260 RID: 25184
		private int activityId_;

		// Token: 0x04006261 RID: 25185
		public const int ChapterIdFieldNumber = 15;

		// Token: 0x04006262 RID: 25186
		private int chapterId_;
	}
}
