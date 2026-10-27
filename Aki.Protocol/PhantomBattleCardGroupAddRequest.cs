using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C47 RID: 3143
	[NetMessage(EMessageId.PhantomBattleCardGroupAddRequest)]
	public sealed class PhantomBattleCardGroupAddRequest : IMessage<PhantomBattleCardGroupAddRequest>, IMessage, IEquatable<PhantomBattleCardGroupAddRequest>, IDeepCloneable<PhantomBattleCardGroupAddRequest>, IBufferMessage
	{
		// Token: 0x060110BF RID: 69823 RVA: 0x0027F177 File Offset: 0x0027D377
		[NullableContext(1)]
		public static PhantomBattleCardGroupAddRequest Create()
		{
			return new PhantomBattleCardGroupAddRequest();
		}

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x060110C0 RID: 69824 RVA: 0x0027F17E File Offset: 0x0027D37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x060110C1 RID: 69825 RVA: 0x0027F181 File Offset: 0x0027D381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupAddRequest.Descriptor;
			}
		}

		// Token: 0x060110C2 RID: 69826 RVA: 0x0027F188 File Offset: 0x0027D388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupAddRequest()
		{
		}

		// Token: 0x060110C3 RID: 69827 RVA: 0x0027F1A8 File Offset: 0x0027D3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupAddRequest(PhantomBattleCardGroupAddRequest other) : this()
		{
			this.name_ = other.name_;
			this.equipCardIds_ = other.equipCardIds_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060110C4 RID: 69828 RVA: 0x0027F1F5 File Offset: 0x0027D3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupAddRequest Clone()
		{
			return new PhantomBattleCardGroupAddRequest(this);
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x060110C5 RID: 69829 RVA: 0x0027F1FD File Offset: 0x0027D3FD
		// (set) Token: 0x060110C6 RID: 69830 RVA: 0x0027F205 File Offset: 0x0027D405
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

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x060110C7 RID: 69831 RVA: 0x0027F218 File Offset: 0x0027D418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquipCardIds
		{
			get
			{
				return this.equipCardIds_;
			}
		}

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x060110C8 RID: 69832 RVA: 0x0027F220 File Offset: 0x0027D420
		// (set) Token: 0x060110C9 RID: 69833 RVA: 0x0027F228 File Offset: 0x0027D428
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

		// Token: 0x060110CA RID: 69834 RVA: 0x0027F231 File Offset: 0x0027D431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupAddRequest);
		}

		// Token: 0x060110CB RID: 69835 RVA: 0x0027F240 File Offset: 0x0027D440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupAddRequest other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.equipCardIds_.Equals(other.equipCardIds_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060110CC RID: 69836 RVA: 0x0027F2A4 File Offset: 0x0027D4A4
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

		// Token: 0x060110CD RID: 69837 RVA: 0x0027F30C File Offset: 0x0027D50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060110CE RID: 69838 RVA: 0x0027F319 File Offset: 0x0027D519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060110CF RID: 69839 RVA: 0x0027F324 File Offset: 0x0027D524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			this.equipCardIds_.WriteTo(ref output, PhantomBattleCardGroupAddRequest._repeated_equipCardIds_codec);
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060110D0 RID: 69840 RVA: 0x0027F394 File Offset: 0x0027D594
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

		// Token: 0x060110D1 RID: 69841 RVA: 0x0027F404 File Offset: 0x0027D604
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

		// Token: 0x060110D2 RID: 69842 RVA: 0x0027F46A File Offset: 0x0027D66A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060110D3 RID: 69843 RVA: 0x0027F474 File Offset: 0x0027D674
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
				if (num <= 72U)
				{
					if (num == 32U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 74U)
					{
						goto IL_46;
					}
					if (num == 82U)
					{
						this.Name = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.equipCardIds_.AddEntriesFrom(ref input, PhantomBattleCardGroupAddRequest._repeated_equipCardIds_codec);
			}
		}

		// Token: 0x04006C0B RID: 27659
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C0C RID: 27660
		public const int NameFieldNumber = 10;

		// Token: 0x04006C0D RID: 27661
		private string name_ = "";

		// Token: 0x04006C0E RID: 27662
		public const int EquipCardIdsFieldNumber = 9;

		// Token: 0x04006C0F RID: 27663
		private static readonly FieldCodec<int> _repeated_equipCardIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04006C10 RID: 27664
		private readonly RepeatedField<int> equipCardIds_ = new RepeatedField<int>();

		// Token: 0x04006C11 RID: 27665
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04006C12 RID: 27666
		private int activityId_;
	}
}
