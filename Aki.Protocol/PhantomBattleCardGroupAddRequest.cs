using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C37 RID: 3127
	[NetMessage(EMessageId.PhantomBattleCardGroupAddRequest)]
	public sealed class PhantomBattleCardGroupAddRequest : IMessage<PhantomBattleCardGroupAddRequest>, IMessage, IEquatable<PhantomBattleCardGroupAddRequest>, IDeepCloneable<PhantomBattleCardGroupAddRequest>, IBufferMessage
	{
		// Token: 0x06010FBF RID: 69567 RVA: 0x0027D40F File Offset: 0x0027B60F
		[NullableContext(1)]
		public static PhantomBattleCardGroupAddRequest Create()
		{
			return new PhantomBattleCardGroupAddRequest();
		}

		// Token: 0x1700381F RID: 14367
		// (get) Token: 0x06010FC0 RID: 69568 RVA: 0x0027D416 File Offset: 0x0027B616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003820 RID: 14368
		// (get) Token: 0x06010FC1 RID: 69569 RVA: 0x0027D419 File Offset: 0x0027B619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupAddRequest.Descriptor;
			}
		}

		// Token: 0x06010FC2 RID: 69570 RVA: 0x0027D420 File Offset: 0x0027B620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupAddRequest()
		{
		}

		// Token: 0x06010FC3 RID: 69571 RVA: 0x0027D440 File Offset: 0x0027B640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupAddRequest(PhantomBattleCardGroupAddRequest other) : this()
		{
			this.name_ = other.name_;
			this.equipCardIds_ = other.equipCardIds_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010FC4 RID: 69572 RVA: 0x0027D48D File Offset: 0x0027B68D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupAddRequest Clone()
		{
			return new PhantomBattleCardGroupAddRequest(this);
		}

		// Token: 0x17003821 RID: 14369
		// (get) Token: 0x06010FC5 RID: 69573 RVA: 0x0027D495 File Offset: 0x0027B695
		// (set) Token: 0x06010FC6 RID: 69574 RVA: 0x0027D49D File Offset: 0x0027B69D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003822 RID: 14370
		// (get) Token: 0x06010FC7 RID: 69575 RVA: 0x0027D4B0 File Offset: 0x0027B6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquipCardIds
		{
			get
			{
				return this.equipCardIds_;
			}
		}

		// Token: 0x17003823 RID: 14371
		// (get) Token: 0x06010FC8 RID: 69576 RVA: 0x0027D4B8 File Offset: 0x0027B6B8
		// (set) Token: 0x06010FC9 RID: 69577 RVA: 0x0027D4C0 File Offset: 0x0027B6C0
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

		// Token: 0x06010FCA RID: 69578 RVA: 0x0027D4C9 File Offset: 0x0027B6C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupAddRequest);
		}

		// Token: 0x06010FCB RID: 69579 RVA: 0x0027D4D8 File Offset: 0x0027B6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupAddRequest other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.equipCardIds_.Equals(other.equipCardIds_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010FCC RID: 69580 RVA: 0x0027D53C File Offset: 0x0027B73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			num ^= this.equipCardIds_.GetHashCode();
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

		// Token: 0x06010FCD RID: 69581 RVA: 0x0027D5A4 File Offset: 0x0027B7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010FCE RID: 69582 RVA: 0x0027D5B1 File Offset: 0x0027B7B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010FCF RID: 69583 RVA: 0x0027D5BC File Offset: 0x0027B7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.equipCardIds_.WriteTo(ref output, PhantomBattleCardGroupAddRequest._repeated_equipCardIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010FD0 RID: 69584 RVA: 0x0027D62C File Offset: 0x0027B82C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			num += this.equipCardIds_.CalculateSize(PhantomBattleCardGroupAddRequest._repeated_equipCardIds_codec);
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

		// Token: 0x06010FD1 RID: 69585 RVA: 0x0027D69C File Offset: 0x0027B89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardGroupAddRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this.equipCardIds_.Add(other.equipCardIds_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010FD2 RID: 69586 RVA: 0x0027D702 File Offset: 0x0027B902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010FD3 RID: 69587 RVA: 0x0027D70C File Offset: 0x0027B90C
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
				if (num <= 42U)
				{
					if (num == 40U || num == 42U)
					{
						this.equipCardIds_.AddEntriesFrom(ref input, PhantomBattleCardGroupAddRequest._repeated_equipCardIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 106U)
					{
						this.Name = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006C1F RID: 27679
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C20 RID: 27680
		public const int NameFieldNumber = 13;

		// Token: 0x04006C21 RID: 27681
		private string name_ = "";

		// Token: 0x04006C22 RID: 27682
		public const int EquipCardIdsFieldNumber = 5;

		// Token: 0x04006C23 RID: 27683
		private static readonly FieldCodec<int> _repeated_equipCardIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04006C24 RID: 27684
		private readonly RepeatedField<int> equipCardIds_ = new RepeatedField<int>();

		// Token: 0x04006C25 RID: 27685
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x04006C26 RID: 27686
		private int activityId_;
	}
}
