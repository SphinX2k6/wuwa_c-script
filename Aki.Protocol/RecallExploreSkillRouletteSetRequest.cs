using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E96 RID: 3734
	[NetMessage(EMessageId.RecallExploreSkillRouletteSetRequest)]
	public sealed class RecallExploreSkillRouletteSetRequest : IMessage<RecallExploreSkillRouletteSetRequest>, IMessage, IEquatable<RecallExploreSkillRouletteSetRequest>, IDeepCloneable<RecallExploreSkillRouletteSetRequest>, IBufferMessage
	{
		// Token: 0x06014121 RID: 82209 RVA: 0x002EC689 File Offset: 0x002EA889
		[NullableContext(1)]
		public static RecallExploreSkillRouletteSetRequest Create()
		{
			return new RecallExploreSkillRouletteSetRequest();
		}

		// Token: 0x170042C7 RID: 17095
		// (get) Token: 0x06014122 RID: 82210 RVA: 0x002EC690 File Offset: 0x002EA890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042C8 RID: 17096
		// (get) Token: 0x06014123 RID: 82211 RVA: 0x002EC693 File Offset: 0x002EA893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallExploreSkillRouletteSetRequest.Descriptor;
			}
		}

		// Token: 0x06014124 RID: 82212 RVA: 0x002EC69A File Offset: 0x002EA89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteSetRequest()
		{
		}

		// Token: 0x06014125 RID: 82213 RVA: 0x002EC6A2 File Offset: 0x002EA8A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteSetRequest(RecallExploreSkillRouletteSetRequest other) : this()
		{
			this.extraItemId_ = other.extraItemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014126 RID: 82214 RVA: 0x002EC6C7 File Offset: 0x002EA8C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallExploreSkillRouletteSetRequest Clone()
		{
			return new RecallExploreSkillRouletteSetRequest(this);
		}

		// Token: 0x170042C9 RID: 17097
		// (get) Token: 0x06014127 RID: 82215 RVA: 0x002EC6CF File Offset: 0x002EA8CF
		// (set) Token: 0x06014128 RID: 82216 RVA: 0x002EC6D7 File Offset: 0x002EA8D7
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

		// Token: 0x06014129 RID: 82217 RVA: 0x002EC6E0 File Offset: 0x002EA8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallExploreSkillRouletteSetRequest);
		}

		// Token: 0x0601412A RID: 82218 RVA: 0x002EC6EE File Offset: 0x002EA8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallExploreSkillRouletteSetRequest other)
		{
			return other != null && (other == this || (this.ExtraItemId == other.ExtraItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601412B RID: 82219 RVA: 0x002EC71C File Offset: 0x002EA91C
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

		// Token: 0x0601412C RID: 82220 RVA: 0x002EC75B File Offset: 0x002EA95B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601412D RID: 82221 RVA: 0x002EC768 File Offset: 0x002EA968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601412E RID: 82222 RVA: 0x002EC771 File Offset: 0x002EA971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExtraItemId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ExtraItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601412F RID: 82223 RVA: 0x002EC7A4 File Offset: 0x002EA9A4
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

		// Token: 0x06014130 RID: 82224 RVA: 0x002EC7E2 File Offset: 0x002EA9E2
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

		// Token: 0x06014131 RID: 82225 RVA: 0x002EC813 File Offset: 0x002EAA13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014132 RID: 82226 RVA: 0x002EC81C File Offset: 0x002EAA1C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ExtraItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007ACB RID: 31435
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007ACC RID: 31436
		public const int ExtraItemIdFieldNumber = 11;

		// Token: 0x04007ACD RID: 31437
		private int extraItemId_;
	}
}
