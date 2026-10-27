using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D7 RID: 471
	[NetMessage(EMessageId.BossRushFailResultNotify)]
	public sealed class BossRushFailResultNotify : IMessage<BossRushFailResultNotify>, IMessage, IEquatable<BossRushFailResultNotify>, IDeepCloneable<BossRushFailResultNotify>, IBufferMessage
	{
		// Token: 0x0600355D RID: 13661 RVA: 0x0008627D File Offset: 0x0008447D
		[NullableContext(1)]
		public static BossRushFailResultNotify Create()
		{
			return new BossRushFailResultNotify();
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x0600355E RID: 13662 RVA: 0x00086284 File Offset: 0x00084484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x0600355F RID: 13663 RVA: 0x00086287 File Offset: 0x00084487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushFailResultNotify.Descriptor;
			}
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x0008628E File Offset: 0x0008448E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushFailResultNotify()
		{
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x00086296 File Offset: 0x00084496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushFailResultNotify(BossRushFailResultNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x000862AF File Offset: 0x000844AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushFailResultNotify Clone()
		{
			return new BossRushFailResultNotify(this);
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x000862B7 File Offset: 0x000844B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushFailResultNotify);
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x000862C5 File Offset: 0x000844C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushFailResultNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x000862E4 File Offset: 0x000844E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x0008630A File Offset: 0x0008450A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x00086317 File Offset: 0x00084517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x00086320 File Offset: 0x00084520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x00086338 File Offset: 0x00084538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x0008635E File Offset: 0x0008455E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushFailResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x0008637B File Offset: 0x0008457B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x00086384 File Offset: 0x00084584
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A47 RID: 10823
		private UnknownFieldSet _unknownFields;
	}
}
