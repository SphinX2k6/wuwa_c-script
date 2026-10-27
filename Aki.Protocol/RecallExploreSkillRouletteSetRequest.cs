using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA6 RID: 3750
	[NetMessage(EMessageId.RecallExploreSkillRouletteSetRequest)]
	public sealed class RecallExploreSkillRouletteSetRequest : IMessage<RecallExploreSkillRouletteSetRequest>, IMessage, IEquatable<RecallExploreSkillRouletteSetRequest>, IDeepCloneable<RecallExploreSkillRouletteSetRequest>, IBufferMessage
	{
		// Token: 0x06014206 RID: 82438 RVA: 0x002EDD35 File Offset: 0x002EBF35
		[NullableContext(1)]
		public static RecallExploreSkillRouletteSetRequest Create()
		{
			return new RecallExploreSkillRouletteSetRequest();
		}

		// Token: 0x170042F1 RID: 17137
		// (get) Token: 0x06014207 RID: 82439 RVA: 0x002EDD3C File Offset: 0x002EBF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042F2 RID: 17138
		// (get) Token: 0x06014208 RID: 82440 RVA: 0x002EDD3F File Offset: 0x002EBF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallExploreSkillRouletteSetRequest.Descriptor;
			}
		}

		// Token: 0x06014209 RID: 82441 RVA: 0x002EDD46 File Offset: 0x002EBF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteSetRequest()
		{
		}

		// Token: 0x0601420A RID: 82442 RVA: 0x002EDD4E File Offset: 0x002EBF4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteSetRequest(RecallExploreSkillRouletteSetRequest other) : this()
		{
			this.extraItemId_ = other.extraItemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601420B RID: 82443 RVA: 0x002EDD73 File Offset: 0x002EBF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteSetRequest Clone()
		{
			return new RecallExploreSkillRouletteSetRequest(this);
		}

		// Token: 0x170042F3 RID: 17139
		// (get) Token: 0x0601420C RID: 82444 RVA: 0x002EDD7B File Offset: 0x002EBF7B
		// (set) Token: 0x0601420D RID: 82445 RVA: 0x002EDD83 File Offset: 0x002EBF83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExtraItemId
		{
			get
			{
				return this.extraItemId_;
			}
			set
			{
				this.extraItemId_ = value;
			}
		}

		// Token: 0x0601420E RID: 82446 RVA: 0x002EDD8C File Offset: 0x002EBF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallExploreSkillRouletteSetRequest);
		}

		// Token: 0x0601420F RID: 82447 RVA: 0x002EDD9A File Offset: 0x002EBF9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallExploreSkillRouletteSetRequest other)
		{
			return other != null && (other == this || (this.ExtraItemId == other.ExtraItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014210 RID: 82448 RVA: 0x002EDDC8 File Offset: 0x002EBFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExtraItemId != 0)
			{
				num ^= this.ExtraItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014211 RID: 82449 RVA: 0x002EDE07 File Offset: 0x002EC007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014212 RID: 82450 RVA: 0x002EDE14 File Offset: 0x002EC014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014213 RID: 82451 RVA: 0x002EDE1D File Offset: 0x002EC01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExtraItemId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ExtraItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014214 RID: 82452 RVA: 0x002EDE50 File Offset: 0x002EC050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExtraItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExtraItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014215 RID: 82453 RVA: 0x002EDE8E File Offset: 0x002EC08E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallExploreSkillRouletteSetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExtraItemId != 0)
			{
				this.ExtraItemId = other.ExtraItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014216 RID: 82454 RVA: 0x002EDEBF File Offset: 0x002EC0BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014217 RID: 82455 RVA: 0x002EDEC8 File Offset: 0x002EC0C8
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ExtraItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007AA1 RID: 31393
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AA2 RID: 31394
		public const int ExtraItemIdFieldNumber = 12;

		// Token: 0x04007AA3 RID: 31395
		private int extraItemId_;
	}
}
