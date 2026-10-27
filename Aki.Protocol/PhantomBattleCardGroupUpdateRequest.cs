using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C4F RID: 3151
	[NetMessage(EMessageId.PhantomBattleCardGroupUpdateRequest)]
	public sealed class PhantomBattleCardGroupUpdateRequest : IMessage<PhantomBattleCardGroupUpdateRequest>, IMessage, IEquatable<PhantomBattleCardGroupUpdateRequest>, IDeepCloneable<PhantomBattleCardGroupUpdateRequest>, IBufferMessage
	{
		// Token: 0x0601116A RID: 69994 RVA: 0x00280BDB File Offset: 0x0027EDDB
		[NullableContext(1)]
		public static PhantomBattleCardGroupUpdateRequest Create()
		{
			return new PhantomBattleCardGroupUpdateRequest();
		}

		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x0601116B RID: 69995 RVA: 0x00280BE2 File Offset: 0x0027EDE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x0601116C RID: 69996 RVA: 0x00280BE5 File Offset: 0x0027EDE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0601116D RID: 69997 RVA: 0x00280BEC File Offset: 0x0027EDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupUpdateRequest()
		{
		}

		// Token: 0x0601116E RID: 69998 RVA: 0x00280C00 File Offset: 0x0027EE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupUpdateRequest(PhantomBattleCardGroupUpdateRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.equipCardIds_ = other.equipCardIds_.Clone();
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601116F RID: 69999 RVA: 0x00280C4D File Offset: 0x0027EE4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupUpdateRequest Clone()
		{
			return new PhantomBattleCardGroupUpdateRequest(this);
		}

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x06011170 RID: 70000 RVA: 0x00280C55 File Offset: 0x0027EE55
		// (set) Token: 0x06011171 RID: 70001 RVA: 0x00280C5D File Offset: 0x0027EE5D
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

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x06011172 RID: 70002 RVA: 0x00280C66 File Offset: 0x0027EE66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquipCardIds
		{
			get
			{
				return this.equipCardIds_;
			}
		}

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x06011173 RID: 70003 RVA: 0x00280C6E File Offset: 0x0027EE6E
		// (set) Token: 0x06011174 RID: 70004 RVA: 0x00280C76 File Offset: 0x0027EE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x06011175 RID: 70005 RVA: 0x00280C7F File Offset: 0x0027EE7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupUpdateRequest);
		}

		// Token: 0x06011176 RID: 70006 RVA: 0x00280C90 File Offset: 0x0027EE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupUpdateRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.equipCardIds_.Equals(other.equipCardIds_) && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011177 RID: 70007 RVA: 0x00280CF0 File Offset: 0x0027EEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.equipCardIds_.GetHashCode();
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011178 RID: 70008 RVA: 0x00280D56 File Offset: 0x0027EF56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011179 RID: 70009 RVA: 0x00280D63 File Offset: 0x0027EF63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601117A RID: 70010 RVA: 0x00280D6C File Offset: 0x0027EF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.equipCardIds_.WriteTo(ref output, PhantomBattleCardGroupUpdateRequest._repeated_equipCardIds_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601117B RID: 70011 RVA: 0x00280DD8 File Offset: 0x0027EFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.equipCardIds_.CalculateSize(PhantomBattleCardGroupUpdateRequest._repeated_equipCardIds_codec);
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601117C RID: 70012 RVA: 0x00280E44 File Offset: 0x0027F044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardGroupUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.equipCardIds_.Add(other.equipCardIds_);
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601117D RID: 70013 RVA: 0x00280EA5 File Offset: 0x0027F0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601117E RID: 70014 RVA: 0x00280EB0 File Offset: 0x0027F0B0
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
				if (num <= 98U)
				{
					if (num == 96U || num == 98U)
					{
						this.equipCardIds_.AddEntriesFrom(ref input, PhantomBattleCardGroupUpdateRequest._repeated_equipCardIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006C46 RID: 27718
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C47 RID: 27719
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04006C48 RID: 27720
		private int activityId_;

		// Token: 0x04006C49 RID: 27721
		public const int EquipCardIdsFieldNumber = 12;

		// Token: 0x04006C4A RID: 27722
		private static readonly FieldCodec<int> _repeated_equipCardIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04006C4B RID: 27723
		private readonly RepeatedField<int> equipCardIds_ = new RepeatedField<int>();

		// Token: 0x04006C4C RID: 27724
		public const int IndexFieldNumber = 15;

		// Token: 0x04006C4D RID: 27725
		private int index_;
	}
}
