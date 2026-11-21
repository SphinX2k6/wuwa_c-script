using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200157E RID: 5502
	[NetMessage(EMessageId.WeekCardRewardRequest)]
	public sealed class WeekCardRewardRequest : IMessage<WeekCardRewardRequest>, IMessage, IEquatable<WeekCardRewardRequest>, IDeepCloneable<WeekCardRewardRequest>, IBufferMessage
	{
		// Token: 0x0601D21B RID: 119323 RVA: 0x00437F7A File Offset: 0x0043617A
		[NullableContext(1)]
		public static WeekCardRewardRequest Create()
		{
			return new WeekCardRewardRequest();
		}

		// Token: 0x17006291 RID: 25233
		// (get) Token: 0x0601D21C RID: 119324 RVA: 0x00437F81 File Offset: 0x00436181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006292 RID: 25234
		// (get) Token: 0x0601D21D RID: 119325 RVA: 0x00437F84 File Offset: 0x00436184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeekCardRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601D21E RID: 119326 RVA: 0x00437F8B File Offset: 0x0043618B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardRewardRequest()
		{
		}

		// Token: 0x0601D21F RID: 119327 RVA: 0x00437F93 File Offset: 0x00436193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardRewardRequest(WeekCardRewardRequest other) : this()
		{
			this.weekCardContentId_ = other.weekCardContentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D220 RID: 119328 RVA: 0x00437FB8 File Offset: 0x004361B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardRewardRequest Clone()
		{
			return new WeekCardRewardRequest(this);
		}

		// Token: 0x17006293 RID: 25235
		// (get) Token: 0x0601D221 RID: 119329 RVA: 0x00437FC0 File Offset: 0x004361C0
		// (set) Token: 0x0601D222 RID: 119330 RVA: 0x00437FC8 File Offset: 0x004361C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeekCardContentId
		{
			get
			{
				return this.weekCardContentId_;
			}
			set
			{
				this.weekCardContentId_ = value;
			}
		}

		// Token: 0x0601D223 RID: 119331 RVA: 0x00437FD1 File Offset: 0x004361D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeekCardRewardRequest);
		}

		// Token: 0x0601D224 RID: 119332 RVA: 0x00437FDF File Offset: 0x004361DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeekCardRewardRequest other)
		{
			return other != null && (other == this || (this.WeekCardContentId == other.WeekCardContentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D225 RID: 119333 RVA: 0x00438010 File Offset: 0x00436210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeekCardContentId != 0)
			{
				num ^= this.WeekCardContentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D226 RID: 119334 RVA: 0x0043804F File Offset: 0x0043624F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D227 RID: 119335 RVA: 0x0043805C File Offset: 0x0043625C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D228 RID: 119336 RVA: 0x00438065 File Offset: 0x00436265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeekCardContentId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.WeekCardContentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D229 RID: 119337 RVA: 0x00438098 File Offset: 0x00436298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeekCardContentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeekCardContentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D22A RID: 119338 RVA: 0x004380D6 File Offset: 0x004362D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeekCardRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeekCardContentId != 0)
			{
				this.WeekCardContentId = other.WeekCardContentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D22B RID: 119339 RVA: 0x00438107 File Offset: 0x00436307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D22C RID: 119340 RVA: 0x00438110 File Offset: 0x00436310
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WeekCardContentId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A743 RID: 42819
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A744 RID: 42820
		public const int WeekCardContentIdFieldNumber = 14;

		// Token: 0x0400A745 RID: 42821
		private int weekCardContentId_;
	}
}
