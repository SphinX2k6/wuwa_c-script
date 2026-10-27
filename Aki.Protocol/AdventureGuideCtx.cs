using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000BA RID: 186
	public sealed class AdventureGuideCtx : IMessage<AdventureGuideCtx>, IMessage, IEquatable<AdventureGuideCtx>, IDeepCloneable<AdventureGuideCtx>, IBufferMessage
	{
		// Token: 0x06001E43 RID: 7747 RVA: 0x00052AE2 File Offset: 0x00050CE2
		[NullableContext(1)]
		public static AdventureGuideCtx Create()
		{
			return new AdventureGuideCtx();
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x00052AE9 File Offset: 0x00050CE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001E45 RID: 7749 RVA: 0x00052AEC File Offset: 0x00050CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureGuideCtx.Descriptor;
			}
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x00052AF3 File Offset: 0x00050CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureGuideCtx()
		{
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00052AFB File Offset: 0x00050CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureGuideCtx(AdventureGuideCtx other) : this()
		{
			this.dungeonDetectionId_ = other.dungeonDetectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00052B20 File Offset: 0x00050D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureGuideCtx Clone()
		{
			return new AdventureGuideCtx(this);
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001E49 RID: 7753 RVA: 0x00052B28 File Offset: 0x00050D28
		// (set) Token: 0x06001E4A RID: 7754 RVA: 0x00052B30 File Offset: 0x00050D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DungeonDetectionId
		{
			get
			{
				return this.dungeonDetectionId_;
			}
			set
			{
				this.dungeonDetectionId_ = value;
			}
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00052B39 File Offset: 0x00050D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureGuideCtx);
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00052B47 File Offset: 0x00050D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureGuideCtx other)
		{
			return other != null && (other == this || (this.DungeonDetectionId == other.DungeonDetectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00052B78 File Offset: 0x00050D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DungeonDetectionId != 0)
			{
				num ^= this.DungeonDetectionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00052BB7 File Offset: 0x00050DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00052BC4 File Offset: 0x00050DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00052BCD File Offset: 0x00050DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DungeonDetectionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DungeonDetectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00052C00 File Offset: 0x00050E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DungeonDetectionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DungeonDetectionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00052C3E File Offset: 0x00050E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureGuideCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DungeonDetectionId != 0)
			{
				this.DungeonDetectionId = other.DungeonDetectionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00052C6F File Offset: 0x00050E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00052C78 File Offset: 0x00050E78
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DungeonDetectionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002352 RID: 9042
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002353 RID: 9043
		public const int DungeonDetectionIdFieldNumber = 1;

		// Token: 0x04002354 RID: 9044
		private int dungeonDetectionId_;
	}
}
