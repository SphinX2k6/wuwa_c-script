using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C79 RID: 3193
	[NetMessage(EMessageId.PhantomBattleFourCTaskDealCardNotify)]
	public sealed class PhantomBattleFourCTaskDealCardNotify : IMessage<PhantomBattleFourCTaskDealCardNotify>, IMessage, IEquatable<PhantomBattleFourCTaskDealCardNotify>, IDeepCloneable<PhantomBattleFourCTaskDealCardNotify>, IBufferMessage
	{
		// Token: 0x06011556 RID: 70998 RVA: 0x0028ACB4 File Offset: 0x00288EB4
		[NullableContext(1)]
		public static PhantomBattleFourCTaskDealCardNotify Create()
		{
			return new PhantomBattleFourCTaskDealCardNotify();
		}

		// Token: 0x17003964 RID: 14692
		// (get) Token: 0x06011557 RID: 70999 RVA: 0x0028ACBB File Offset: 0x00288EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003965 RID: 14693
		// (get) Token: 0x06011558 RID: 71000 RVA: 0x0028ACBE File Offset: 0x00288EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleFourCTaskDealCardNotify.Descriptor;
			}
		}

		// Token: 0x06011559 RID: 71001 RVA: 0x0028ACC5 File Offset: 0x00288EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourCTaskDealCardNotify()
		{
		}

		// Token: 0x0601155A RID: 71002 RVA: 0x0028ACCD File Offset: 0x00288ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourCTaskDealCardNotify(PhantomBattleFourCTaskDealCardNotify other) : this()
		{
			this.phantomBattleHandCardInfo_ = ((other.phantomBattleHandCardInfo_ != null) ? other.phantomBattleHandCardInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601155B RID: 71003 RVA: 0x0028AD02 File Offset: 0x00288F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourCTaskDealCardNotify Clone()
		{
			return new PhantomBattleFourCTaskDealCardNotify(this);
		}

		// Token: 0x17003966 RID: 14694
		// (get) Token: 0x0601155C RID: 71004 RVA: 0x0028AD0A File Offset: 0x00288F0A
		// (set) Token: 0x0601155D RID: 71005 RVA: 0x0028AD12 File Offset: 0x00288F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfo PhantomBattleHandCardInfo
		{
			get
			{
				return this.phantomBattleHandCardInfo_;
			}
			set
			{
				this.phantomBattleHandCardInfo_ = value;
			}
		}

		// Token: 0x0601155E RID: 71006 RVA: 0x0028AD1B File Offset: 0x00288F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleFourCTaskDealCardNotify);
		}

		// Token: 0x0601155F RID: 71007 RVA: 0x0028AD29 File Offset: 0x00288F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleFourCTaskDealCardNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleHandCardInfo, other.PhantomBattleHandCardInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011560 RID: 71008 RVA: 0x0028AD5C File Offset: 0x00288F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.phantomBattleHandCardInfo_ != null)
			{
				num ^= this.PhantomBattleHandCardInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011561 RID: 71009 RVA: 0x0028AD98 File Offset: 0x00288F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011562 RID: 71010 RVA: 0x0028ADA5 File Offset: 0x00288FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011563 RID: 71011 RVA: 0x0028ADAE File Offset: 0x00288FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleHandCardInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.PhantomBattleHandCardInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011564 RID: 71012 RVA: 0x0028ADE0 File Offset: 0x00288FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.phantomBattleHandCardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleHandCardInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011565 RID: 71013 RVA: 0x0028AE20 File Offset: 0x00289020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleFourCTaskDealCardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.phantomBattleHandCardInfo_ != null)
			{
				if (this.phantomBattleHandCardInfo_ == null)
				{
					this.PhantomBattleHandCardInfo = new PhantomBattleHandCardInfo();
				}
				this.PhantomBattleHandCardInfo.MergeFrom(other.PhantomBattleHandCardInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011566 RID: 71014 RVA: 0x0028AE74 File Offset: 0x00289074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011567 RID: 71015 RVA: 0x0028AE80 File Offset: 0x00289080
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.phantomBattleHandCardInfo_ == null)
					{
						this.PhantomBattleHandCardInfo = new PhantomBattleHandCardInfo();
					}
					input.ReadMessage(this.PhantomBattleHandCardInfo);
				}
			}
		}

		// Token: 0x04006DF2 RID: 28146
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DF3 RID: 28147
		public const int PhantomBattleHandCardInfoFieldNumber = 8;

		// Token: 0x04006DF4 RID: 28148
		private PhantomBattleHandCardInfo phantomBattleHandCardInfo_;
	}
}
