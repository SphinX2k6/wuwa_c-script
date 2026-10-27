using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B4F RID: 2895
	[NetMessage(EMessageId.NewTowerSeasonTaskDataUpdateResponse)]
	public sealed class NewTowerSeasonTaskDataUpdateResponse : IMessage<NewTowerSeasonTaskDataUpdateResponse>, IMessage, IEquatable<NewTowerSeasonTaskDataUpdateResponse>, IDeepCloneable<NewTowerSeasonTaskDataUpdateResponse>, IBufferMessage
	{
		// Token: 0x0600FB09 RID: 64265 RVA: 0x002495F2 File Offset: 0x002477F2
		[NullableContext(1)]
		public static NewTowerSeasonTaskDataUpdateResponse Create()
		{
			return new NewTowerSeasonTaskDataUpdateResponse();
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x0600FB0A RID: 64266 RVA: 0x002495F9 File Offset: 0x002477F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x0600FB0B RID: 64267 RVA: 0x002495FC File Offset: 0x002477FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerSeasonTaskDataUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600FB0C RID: 64268 RVA: 0x00249603 File Offset: 0x00247803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateResponse()
		{
		}

		// Token: 0x0600FB0D RID: 64269 RVA: 0x00249616 File Offset: 0x00247816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateResponse(NewTowerSeasonTaskDataUpdateResponse other) : this()
		{
			this.seasonTasks_ = other.seasonTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB0E RID: 64270 RVA: 0x00249640 File Offset: 0x00247840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateResponse Clone()
		{
			return new NewTowerSeasonTaskDataUpdateResponse(this);
		}

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x0600FB0F RID: 64271 RVA: 0x00249648 File Offset: 0x00247848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> SeasonTasks
		{
			get
			{
				return this.seasonTasks_;
			}
		}

		// Token: 0x0600FB10 RID: 64272 RVA: 0x00249650 File Offset: 0x00247850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerSeasonTaskDataUpdateResponse);
		}

		// Token: 0x0600FB11 RID: 64273 RVA: 0x0024965E File Offset: 0x0024785E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerSeasonTaskDataUpdateResponse other)
		{
			return other != null && (other == this || (this.seasonTasks_.Equals(other.seasonTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FB12 RID: 64274 RVA: 0x00249694 File Offset: 0x00247894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.seasonTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FB13 RID: 64275 RVA: 0x002496C8 File Offset: 0x002478C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB14 RID: 64276 RVA: 0x002496D5 File Offset: 0x002478D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB15 RID: 64277 RVA: 0x002496DE File Offset: 0x002478DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.seasonTasks_.WriteTo(ref output, NewTowerSeasonTaskDataUpdateResponse._repeated_seasonTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FB16 RID: 64278 RVA: 0x00249708 File Offset: 0x00247908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.seasonTasks_.CalculateSize(NewTowerSeasonTaskDataUpdateResponse._repeated_seasonTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FB17 RID: 64279 RVA: 0x00249741 File Offset: 0x00247941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerSeasonTaskDataUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.seasonTasks_.Add(other.seasonTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FB18 RID: 64280 RVA: 0x0024976F File Offset: 0x0024796F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB19 RID: 64281 RVA: 0x00249778 File Offset: 0x00247978
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.seasonTasks_.AddEntriesFrom(ref input, NewTowerSeasonTaskDataUpdateResponse._repeated_seasonTasks_codec);
				}
			}
		}

		// Token: 0x04006468 RID: 25704
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006469 RID: 25705
		public const int SeasonTasksFieldNumber = 11;

		// Token: 0x0400646A RID: 25706
		private static readonly FieldCodec<ActivityTask> _repeated_seasonTasks_codec = FieldCodec.ForMessage<ActivityTask>(90U, ActivityTask.Parser);

		// Token: 0x0400646B RID: 25707
		private readonly RepeatedField<ActivityTask> seasonTasks_ = new RepeatedField<ActivityTask>();
	}
}
