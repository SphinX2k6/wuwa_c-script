using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF8 RID: 2808
	[NetMessage(EMessageId.NewBieCourseRewardRequest)]
	public sealed class NewBieCourseRewardRequest : IMessage<NewBieCourseRewardRequest>, IMessage, IEquatable<NewBieCourseRewardRequest>, IDeepCloneable<NewBieCourseRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F45A RID: 62554 RVA: 0x0023AE79 File Offset: 0x00239079
		[NullableContext(1)]
		public static NewBieCourseRewardRequest Create()
		{
			return new NewBieCourseRewardRequest();
		}

		// Token: 0x170031C0 RID: 12736
		// (get) Token: 0x0600F45B RID: 62555 RVA: 0x0023AE80 File Offset: 0x00239080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031C1 RID: 12737
		// (get) Token: 0x0600F45C RID: 62556 RVA: 0x0023AE83 File Offset: 0x00239083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewBieCourseRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F45D RID: 62557 RVA: 0x0023AE8A File Offset: 0x0023908A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardRequest()
		{
		}

		// Token: 0x0600F45E RID: 62558 RVA: 0x0023AE92 File Offset: 0x00239092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardRequest(NewBieCourseRewardRequest other) : this()
		{
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F45F RID: 62559 RVA: 0x0023AEB7 File Offset: 0x002390B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardRequest Clone()
		{
			return new NewBieCourseRewardRequest(this);
		}

		// Token: 0x170031C2 RID: 12738
		// (get) Token: 0x0600F460 RID: 62560 RVA: 0x0023AEBF File Offset: 0x002390BF
		// (set) Token: 0x0600F461 RID: 62561 RVA: 0x0023AEC7 File Offset: 0x002390C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600F462 RID: 62562 RVA: 0x0023AED0 File Offset: 0x002390D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewBieCourseRewardRequest);
		}

		// Token: 0x0600F463 RID: 62563 RVA: 0x0023AEDE File Offset: 0x002390DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewBieCourseRewardRequest other)
		{
			return other != null && (other == this || (this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F464 RID: 62564 RVA: 0x0023AF0C File Offset: 0x0023910C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F465 RID: 62565 RVA: 0x0023AF4B File Offset: 0x0023914B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F466 RID: 62566 RVA: 0x0023AF58 File Offset: 0x00239158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F467 RID: 62567 RVA: 0x0023AF61 File Offset: 0x00239161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F468 RID: 62568 RVA: 0x0023AF94 File Offset: 0x00239194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F469 RID: 62569 RVA: 0x0023AFD2 File Offset: 0x002391D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewBieCourseRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F46A RID: 62570 RVA: 0x0023B003 File Offset: 0x00239203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F46B RID: 62571 RVA: 0x0023B00C File Offset: 0x0023920C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x040062BD RID: 25277
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062BE RID: 25278
		public const int LevelFieldNumber = 9;

		// Token: 0x040062BF RID: 25279
		private int level_;
	}
}
