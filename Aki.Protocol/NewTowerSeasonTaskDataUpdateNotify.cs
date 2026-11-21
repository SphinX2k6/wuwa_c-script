using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B3C RID: 2876
	[NetMessage(EMessageId.NewTowerSeasonTaskDataUpdateNotify)]
	public sealed class NewTowerSeasonTaskDataUpdateNotify : IMessage<NewTowerSeasonTaskDataUpdateNotify>, IMessage, IEquatable<NewTowerSeasonTaskDataUpdateNotify>, IDeepCloneable<NewTowerSeasonTaskDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F9CB RID: 63947 RVA: 0x00246F45 File Offset: 0x00245145
		[NullableContext(1)]
		public static NewTowerSeasonTaskDataUpdateNotify Create()
		{
			return new NewTowerSeasonTaskDataUpdateNotify();
		}

		// Token: 0x170032E9 RID: 13033
		// (get) Token: 0x0600F9CC RID: 63948 RVA: 0x00246F4C File Offset: 0x0024514C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x0600F9CD RID: 63949 RVA: 0x00246F4F File Offset: 0x0024514F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerSeasonTaskDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F9CE RID: 63950 RVA: 0x00246F56 File Offset: 0x00245156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateNotify()
		{
		}

		// Token: 0x0600F9CF RID: 63951 RVA: 0x00246F80 File Offset: 0x00245180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateNotify(NewTowerSeasonTaskDataUpdateNotify other) : this()
		{
			this.seasonTasks_ = other.seasonTasks_.Clone();
			this.adds_ = other.adds_.Clone();
			this.removes_ = other.removes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F9D0 RID: 63952 RVA: 0x00246FD7 File Offset: 0x002451D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateNotify Clone()
		{
			return new NewTowerSeasonTaskDataUpdateNotify(this);
		}

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0600F9D1 RID: 63953 RVA: 0x00246FDF File Offset: 0x002451DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> SeasonTasks
		{
			get
			{
				return this.seasonTasks_;
			}
		}

		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x0600F9D2 RID: 63954 RVA: 0x00246FE7 File Offset: 0x002451E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x0600F9D3 RID: 63955 RVA: 0x00246FEF File Offset: 0x002451EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x0600F9D4 RID: 63956 RVA: 0x00246FF7 File Offset: 0x002451F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerSeasonTaskDataUpdateNotify);
		}

		// Token: 0x0600F9D5 RID: 63957 RVA: 0x00247008 File Offset: 0x00245208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerSeasonTaskDataUpdateNotify other)
		{
			return other != null && (other == this || (this.seasonTasks_.Equals(other.seasonTasks_) && this.adds_.Equals(other.adds_) && this.removes_.Equals(other.removes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F9D6 RID: 63958 RVA: 0x00247070 File Offset: 0x00245270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.seasonTasks_.GetHashCode();
			num ^= this.adds_.GetHashCode();
			num ^= this.removes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F9D7 RID: 63959 RVA: 0x002470C0 File Offset: 0x002452C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F9D8 RID: 63960 RVA: 0x002470CD File Offset: 0x002452CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F9D9 RID: 63961 RVA: 0x002470D8 File Offset: 0x002452D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.seasonTasks_.WriteTo(ref output, NewTowerSeasonTaskDataUpdateNotify._repeated_seasonTasks_codec);
			this.removes_.WriteTo(ref output, NewTowerSeasonTaskDataUpdateNotify._repeated_removes_codec);
			this.adds_.WriteTo(ref output, NewTowerSeasonTaskDataUpdateNotify._repeated_adds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F9DA RID: 63962 RVA: 0x0024712C File Offset: 0x0024532C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.seasonTasks_.CalculateSize(NewTowerSeasonTaskDataUpdateNotify._repeated_seasonTasks_codec);
			num += this.adds_.CalculateSize(NewTowerSeasonTaskDataUpdateNotify._repeated_adds_codec);
			num += this.removes_.CalculateSize(NewTowerSeasonTaskDataUpdateNotify._repeated_removes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F9DB RID: 63963 RVA: 0x0024718C File Offset: 0x0024538C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerSeasonTaskDataUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.seasonTasks_.Add(other.seasonTasks_);
			this.adds_.Add(other.adds_);
			this.removes_.Add(other.removes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F9DC RID: 63964 RVA: 0x002471E7 File Offset: 0x002453E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F9DD RID: 63965 RVA: 0x002471F0 File Offset: 0x002453F0
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
					if (num == 58U)
					{
						this.seasonTasks_.AddEntriesFrom(ref input, NewTowerSeasonTaskDataUpdateNotify._repeated_seasonTasks_codec);
						continue;
					}
					if (num == 72U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 74U)
					{
						goto IL_4B;
					}
					if (num == 114U)
					{
						this.adds_.AddEntriesFrom(ref input, NewTowerSeasonTaskDataUpdateNotify._repeated_adds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.removes_.AddEntriesFrom(ref input, NewTowerSeasonTaskDataUpdateNotify._repeated_removes_codec);
			}
		}

		// Token: 0x04006466 RID: 25702
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006467 RID: 25703
		public const int SeasonTasksFieldNumber = 7;

		// Token: 0x04006468 RID: 25704
		private static readonly FieldCodec<ActivityTask> _repeated_seasonTasks_codec = FieldCodec.ForMessage<ActivityTask>(58U, ActivityTask.Parser);

		// Token: 0x04006469 RID: 25705
		private readonly RepeatedField<ActivityTask> seasonTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x0400646A RID: 25706
		public const int AddsFieldNumber = 14;

		// Token: 0x0400646B RID: 25707
		private static readonly FieldCodec<ActivityTask> _repeated_adds_codec = FieldCodec.ForMessage<ActivityTask>(114U, ActivityTask.Parser);

		// Token: 0x0400646C RID: 25708
		private readonly RepeatedField<ActivityTask> adds_ = new RepeatedField<ActivityTask>();

		// Token: 0x0400646D RID: 25709
		public const int RemovesFieldNumber = 9;

		// Token: 0x0400646E RID: 25710
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400646F RID: 25711
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();
	}
}
