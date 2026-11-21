using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000346 RID: 838
	public sealed class DangoBrawlDamageInfo : IMessage<DangoBrawlDamageInfo>, IMessage, IEquatable<DangoBrawlDamageInfo>, IDeepCloneable<DangoBrawlDamageInfo>, IBufferMessage
	{
		// Token: 0x0600541E RID: 21534 RVA: 0x000CD499 File Offset: 0x000CB699
		[NullableContext(1)]
		public static DangoBrawlDamageInfo Create()
		{
			return new DangoBrawlDamageInfo();
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x0600541F RID: 21535 RVA: 0x000CD4A0 File Offset: 0x000CB6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06005420 RID: 21536 RVA: 0x000CD4A3 File Offset: 0x000CB6A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlDamageInfo.Descriptor;
			}
		}

		// Token: 0x06005421 RID: 21537 RVA: 0x000CD4AA File Offset: 0x000CB6AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageInfo()
		{
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x000CD4BD File Offset: 0x000CB6BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageInfo(DangoBrawlDamageInfo other) : this()
		{
			this.damages_ = other.damages_.Clone();
			this.isCrit_ = other.isCrit_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005423 RID: 21539 RVA: 0x000CD4F3 File Offset: 0x000CB6F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageInfo Clone()
		{
			return new DangoBrawlDamageInfo(this);
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06005424 RID: 21540 RVA: 0x000CD4FB File Offset: 0x000CB6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DangoBrawlDamageSegment> Damages
		{
			get
			{
				return this.damages_;
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06005425 RID: 21541 RVA: 0x000CD503 File Offset: 0x000CB703
		// (set) Token: 0x06005426 RID: 21542 RVA: 0x000CD50B File Offset: 0x000CB70B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCrit
		{
			get
			{
				return this.isCrit_;
			}
			set
			{
				this.isCrit_ = value;
			}
		}

		// Token: 0x06005427 RID: 21543 RVA: 0x000CD514 File Offset: 0x000CB714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlDamageInfo);
		}

		// Token: 0x06005428 RID: 21544 RVA: 0x000CD524 File Offset: 0x000CB724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlDamageInfo other)
		{
			return other != null && (other == this || (this.damages_.Equals(other.damages_) && this.IsCrit == other.IsCrit && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005429 RID: 21545 RVA: 0x000CD574 File Offset: 0x000CB774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.damages_.GetHashCode();
			if (this.IsCrit)
			{
				num ^= this.IsCrit.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600542A RID: 21546 RVA: 0x000CD5C1 File Offset: 0x000CB7C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600542B RID: 21547 RVA: 0x000CD5CE File Offset: 0x000CB7CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600542C RID: 21548 RVA: 0x000CD5D8 File Offset: 0x000CB7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.damages_.WriteTo(ref output, DangoBrawlDamageInfo._repeated_damages_codec);
			if (this.IsCrit)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsCrit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600542D RID: 21549 RVA: 0x000CD628 File Offset: 0x000CB828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.damages_.CalculateSize(DangoBrawlDamageInfo._repeated_damages_codec);
			if (this.IsCrit)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600542E RID: 21550 RVA: 0x000CD670 File Offset: 0x000CB870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlDamageInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.damages_.Add(other.damages_);
			if (other.IsCrit)
			{
				this.IsCrit = other.IsCrit;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x000CD6BD File Offset: 0x000CB8BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005430 RID: 21552 RVA: 0x000CD6C8 File Offset: 0x000CB8C8
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsCrit = input.ReadBool();
					}
				}
				else
				{
					this.damages_.AddEntriesFrom(ref input, DangoBrawlDamageInfo._repeated_damages_codec);
				}
			}
		}

		// Token: 0x04003402 RID: 13314
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003403 RID: 13315
		public const int DamagesFieldNumber = 1;

		// Token: 0x04003404 RID: 13316
		private static readonly FieldCodec<DangoBrawlDamageSegment> _repeated_damages_codec = FieldCodec.ForMessage<DangoBrawlDamageSegment>(10U, DangoBrawlDamageSegment.Parser);

		// Token: 0x04003405 RID: 13317
		private readonly RepeatedField<DangoBrawlDamageSegment> damages_ = new RepeatedField<DangoBrawlDamageSegment>();

		// Token: 0x04003406 RID: 13318
		public const int IsCritFieldNumber = 2;

		// Token: 0x04003407 RID: 13319
		private bool isCrit_;
	}
}
