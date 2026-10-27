using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B4D RID: 2893
	[NetMessage(EMessageId.NewTowerSeasonTaskDataUpdateNotify)]
	public sealed class NewTowerSeasonTaskDataUpdateNotify : IMessage<NewTowerSeasonTaskDataUpdateNotify>, IMessage, IEquatable<NewTowerSeasonTaskDataUpdateNotify>, IDeepCloneable<NewTowerSeasonTaskDataUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600FAE5 RID: 64229 RVA: 0x00249158 File Offset: 0x00247358
		[NullableContext(1)]
		public static NewTowerSeasonTaskDataUpdateNotify Create()
		{
			return new NewTowerSeasonTaskDataUpdateNotify();
		}

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x0600FAE6 RID: 64230 RVA: 0x0024915F File Offset: 0x0024735F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x0600FAE7 RID: 64231 RVA: 0x00249162 File Offset: 0x00247362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerSeasonTaskDataUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600FAE8 RID: 64232 RVA: 0x00249169 File Offset: 0x00247369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateNotify()
		{
		}

		// Token: 0x0600FAE9 RID: 64233 RVA: 0x00249194 File Offset: 0x00247394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateNotify(NewTowerSeasonTaskDataUpdateNotify other) : this()
		{
			this.seasonTasks_ = other.seasonTasks_.Clone();
			this.adds_ = other.adds_.Clone();
			this.removes_ = other.removes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FAEA RID: 64234 RVA: 0x002491EB File Offset: 0x002473EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateNotify Clone()
		{
			return new NewTowerSeasonTaskDataUpdateNotify(this);
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x0600FAEB RID: 64235 RVA: 0x002491F3 File Offset: 0x002473F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> SeasonTasks
		{
			get
			{
				return this.seasonTasks_;
			}
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x0600FAEC RID: 64236 RVA: 0x002491FB File Offset: 0x002473FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> Adds
		{
			get
			{
				return this.adds_;
			}
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x0600FAED RID: 64237 RVA: 0x00249203 File Offset: 0x00247403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Removes
		{
			get
			{
				return this.removes_;
			}
		}

		// Token: 0x0600FAEE RID: 64238 RVA: 0x0024920B File Offset: 0x0024740B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerSeasonTaskDataUpdateNotify);
		}

		// Token: 0x0600FAEF RID: 64239 RVA: 0x0024921C File Offset: 0x0024741C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerSeasonTaskDataUpdateNotify other)
		{
			return other != null && (other == this || (this.seasonTasks_.Equals(other.seasonTasks_) && this.adds_.Equals(other.adds_) && this.removes_.Equals(other.removes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FAF0 RID: 64240 RVA: 0x00249284 File Offset: 0x00247484
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

		// Token: 0x0600FAF1 RID: 64241 RVA: 0x002492D4 File Offset: 0x002474D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FAF2 RID: 64242 RVA: 0x002492E1 File Offset: 0x002474E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FAF3 RID: 64243 RVA: 0x002492EC File Offset: 0x002474EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.removes_.WriteTo(ref output, NewTowerSeasonTaskDataUpdateNotify._repeated_removes_codec);
			this.seasonTasks_.WriteTo(ref output, NewTowerSeasonTaskDataUpdateNotify._repeated_seasonTasks_codec);
			this.adds_.WriteTo(ref output, NewTowerSeasonTaskDataUpdateNotify._repeated_adds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FAF4 RID: 64244 RVA: 0x00249340 File Offset: 0x00247540
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

		// Token: 0x0600FAF5 RID: 64245 RVA: 0x002493A0 File Offset: 0x002475A0
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

		// Token: 0x0600FAF6 RID: 64246 RVA: 0x002493FB File Offset: 0x002475FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FAF7 RID: 64247 RVA: 0x00249404 File Offset: 0x00247604
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.removes_.AddEntriesFrom(ref input, NewTowerSeasonTaskDataUpdateNotify._repeated_removes_codec);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.seasonTasks_.AddEntriesFrom(ref input, NewTowerSeasonTaskDataUpdateNotify._repeated_seasonTasks_codec);
						continue;
					}
					if (num == 98U)
					{
						this.adds_.AddEntriesFrom(ref input, NewTowerSeasonTaskDataUpdateNotify._repeated_adds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400645D RID: 25693
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400645E RID: 25694
		public const int SeasonTasksFieldNumber = 3;

		// Token: 0x0400645F RID: 25695
		private static readonly FieldCodec<ActivityTask> _repeated_seasonTasks_codec = FieldCodec.ForMessage<ActivityTask>(26U, ActivityTask.Parser);

		// Token: 0x04006460 RID: 25696
		private readonly RepeatedField<ActivityTask> seasonTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x04006461 RID: 25697
		public const int AddsFieldNumber = 12;

		// Token: 0x04006462 RID: 25698
		private static readonly FieldCodec<ActivityTask> _repeated_adds_codec = FieldCodec.ForMessage<ActivityTask>(98U, ActivityTask.Parser);

		// Token: 0x04006463 RID: 25699
		private readonly RepeatedField<ActivityTask> adds_ = new RepeatedField<ActivityTask>();

		// Token: 0x04006464 RID: 25700
		public const int RemovesFieldNumber = 1;

		// Token: 0x04006465 RID: 25701
		private static readonly FieldCodec<int> _repeated_removes_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006466 RID: 25702
		private readonly RepeatedField<int> removes_ = new RepeatedField<int>();
	}
}
