using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B3E RID: 2878
	[NetMessage(EMessageId.NewTowerSeasonTaskDataUpdateResponse)]
	public sealed class NewTowerSeasonTaskDataUpdateResponse : IMessage<NewTowerSeasonTaskDataUpdateResponse>, IMessage, IEquatable<NewTowerSeasonTaskDataUpdateResponse>, IDeepCloneable<NewTowerSeasonTaskDataUpdateResponse>, IBufferMessage
	{
		// Token: 0x0600F9EF RID: 63983 RVA: 0x002473DE File Offset: 0x002455DE
		[NullableContext(1)]
		public static NewTowerSeasonTaskDataUpdateResponse Create()
		{
			return new NewTowerSeasonTaskDataUpdateResponse();
		}

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x0600F9F0 RID: 63984 RVA: 0x002473E5 File Offset: 0x002455E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0600F9F1 RID: 63985 RVA: 0x002473E8 File Offset: 0x002455E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerSeasonTaskDataUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600F9F2 RID: 63986 RVA: 0x002473EF File Offset: 0x002455EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateResponse()
		{
		}

		// Token: 0x0600F9F3 RID: 63987 RVA: 0x00247402 File Offset: 0x00245602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateResponse(NewTowerSeasonTaskDataUpdateResponse other) : this()
		{
			this.seasonTasks_ = other.seasonTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F9F4 RID: 63988 RVA: 0x0024742C File Offset: 0x0024562C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateResponse Clone()
		{
			return new NewTowerSeasonTaskDataUpdateResponse(this);
		}

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x0600F9F5 RID: 63989 RVA: 0x00247434 File Offset: 0x00245634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> SeasonTasks
		{
			get
			{
				return this.seasonTasks_;
			}
		}

		// Token: 0x0600F9F6 RID: 63990 RVA: 0x0024743C File Offset: 0x0024563C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerSeasonTaskDataUpdateResponse);
		}

		// Token: 0x0600F9F7 RID: 63991 RVA: 0x0024744A File Offset: 0x0024564A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerSeasonTaskDataUpdateResponse other)
		{
			return other != null && (other == this || (this.seasonTasks_.Equals(other.seasonTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F9F8 RID: 63992 RVA: 0x00247480 File Offset: 0x00245680
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

		// Token: 0x0600F9F9 RID: 63993 RVA: 0x002474B4 File Offset: 0x002456B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F9FA RID: 63994 RVA: 0x002474C1 File Offset: 0x002456C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F9FB RID: 63995 RVA: 0x002474CA File Offset: 0x002456CA
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

		// Token: 0x0600F9FC RID: 63996 RVA: 0x002474F4 File Offset: 0x002456F4
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

		// Token: 0x0600F9FD RID: 63997 RVA: 0x0024752D File Offset: 0x0024572D
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

		// Token: 0x0600F9FE RID: 63998 RVA: 0x0024755B File Offset: 0x0024575B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F9FF RID: 63999 RVA: 0x00247564 File Offset: 0x00245764
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.seasonTasks_.AddEntriesFrom(ref input, NewTowerSeasonTaskDataUpdateResponse._repeated_seasonTasks_codec);
				}
			}
		}

		// Token: 0x04006471 RID: 25713
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006472 RID: 25714
		public const int SeasonTasksFieldNumber = 13;

		// Token: 0x04006473 RID: 25715
		private static readonly FieldCodec<ActivityTask> _repeated_seasonTasks_codec = FieldCodec.ForMessage<ActivityTask>(106U, ActivityTask.Parser);

		// Token: 0x04006474 RID: 25716
		private readonly RepeatedField<ActivityTask> seasonTasks_ = new RepeatedField<ActivityTask>();
	}
}
