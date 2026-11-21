using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001599 RID: 5529
	[NetMessage(EMessageId.WuWuKujiGachaRequest)]
	public sealed class WuWuKujiGachaRequest : IMessage<WuWuKujiGachaRequest>, IMessage, IEquatable<WuWuKujiGachaRequest>, IDeepCloneable<WuWuKujiGachaRequest>, IBufferMessage
	{
		// Token: 0x0601D458 RID: 119896 RVA: 0x0043D0C4 File Offset: 0x0043B2C4
		[NullableContext(1)]
		public static WuWuKujiGachaRequest Create()
		{
			return new WuWuKujiGachaRequest();
		}

		// Token: 0x1700630E RID: 25358
		// (get) Token: 0x0601D459 RID: 119897 RVA: 0x0043D0CB File Offset: 0x0043B2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700630F RID: 25359
		// (get) Token: 0x0601D45A RID: 119898 RVA: 0x0043D0CE File Offset: 0x0043B2CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuKujiGachaRequest.Descriptor;
			}
		}

		// Token: 0x0601D45B RID: 119899 RVA: 0x0043D0D5 File Offset: 0x0043B2D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiGachaRequest()
		{
		}

		// Token: 0x0601D45C RID: 119900 RVA: 0x0043D0DD File Offset: 0x0043B2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiGachaRequest(WuWuKujiGachaRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D45D RID: 119901 RVA: 0x0043D102 File Offset: 0x0043B302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiGachaRequest Clone()
		{
			return new WuWuKujiGachaRequest(this);
		}

		// Token: 0x17006310 RID: 25360
		// (get) Token: 0x0601D45E RID: 119902 RVA: 0x0043D10A File Offset: 0x0043B30A
		// (set) Token: 0x0601D45F RID: 119903 RVA: 0x0043D112 File Offset: 0x0043B312
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

		// Token: 0x0601D460 RID: 119904 RVA: 0x0043D11B File Offset: 0x0043B31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuKujiGachaRequest);
		}

		// Token: 0x0601D461 RID: 119905 RVA: 0x0043D129 File Offset: 0x0043B329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuKujiGachaRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D462 RID: 119906 RVA: 0x0043D158 File Offset: 0x0043B358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D463 RID: 119907 RVA: 0x0043D197 File Offset: 0x0043B397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D464 RID: 119908 RVA: 0x0043D1A4 File Offset: 0x0043B3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D465 RID: 119909 RVA: 0x0043D1AD File Offset: 0x0043B3AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D466 RID: 119910 RVA: 0x0043D1E0 File Offset: 0x0043B3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D467 RID: 119911 RVA: 0x0043D21E File Offset: 0x0043B41E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WuWuKujiGachaRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D468 RID: 119912 RVA: 0x0043D24F File Offset: 0x0043B44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D469 RID: 119913 RVA: 0x0043D258 File Offset: 0x0043B458
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A7ED RID: 42989
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A7EE RID: 42990
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x0400A7EF RID: 42991
		private int activityId_;
	}
}
