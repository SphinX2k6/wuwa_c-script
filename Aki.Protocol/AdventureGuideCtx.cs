using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000BB RID: 187
	public sealed class AdventureGuideCtx : IMessage<AdventureGuideCtx>, IMessage, IEquatable<AdventureGuideCtx>, IDeepCloneable<AdventureGuideCtx>, IBufferMessage
	{
		// Token: 0x06001E8C RID: 7820 RVA: 0x00053796 File Offset: 0x00051996
		[NullableContext(1)]
		public static AdventureGuideCtx Create()
		{
			return new AdventureGuideCtx();
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x0005379D File Offset: 0x0005199D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x000537A0 File Offset: 0x000519A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureGuideCtx.Descriptor;
			}
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x000537A7 File Offset: 0x000519A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureGuideCtx()
		{
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x000537AF File Offset: 0x000519AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureGuideCtx(AdventureGuideCtx other) : this()
		{
			this.dungeonDetectionId_ = other.dungeonDetectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x000537D4 File Offset: 0x000519D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureGuideCtx Clone()
		{
			return new AdventureGuideCtx(this);
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x000537DC File Offset: 0x000519DC
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x000537E4 File Offset: 0x000519E4
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

		// Token: 0x06001E94 RID: 7828 RVA: 0x000537ED File Offset: 0x000519ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureGuideCtx);
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x000537FB File Offset: 0x000519FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureGuideCtx other)
		{
			return other != null && (other == this || (this.DungeonDetectionId == other.DungeonDetectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x0005382C File Offset: 0x00051A2C
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

		// Token: 0x06001E97 RID: 7831 RVA: 0x0005386B File Offset: 0x00051A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00053878 File Offset: 0x00051A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00053881 File Offset: 0x00051A81
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

		// Token: 0x06001E9A RID: 7834 RVA: 0x000538B4 File Offset: 0x00051AB4
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

		// Token: 0x06001E9B RID: 7835 RVA: 0x000538F2 File Offset: 0x00051AF2
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

		// Token: 0x06001E9C RID: 7836 RVA: 0x00053923 File Offset: 0x00051B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x0005392C File Offset: 0x00051B2C
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

		// Token: 0x040023B5 RID: 9141
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023B6 RID: 9142
		public const int DungeonDetectionIdFieldNumber = 1;

		// Token: 0x040023B7 RID: 9143
		private int dungeonDetectionId_;
	}
}
