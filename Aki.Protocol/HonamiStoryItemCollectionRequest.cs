using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200076C RID: 1900
	[NetMessage(EMessageId.HonamiStoryItemCollectionRequest)]
	public sealed class HonamiStoryItemCollectionRequest : IMessage<HonamiStoryItemCollectionRequest>, IMessage, IEquatable<HonamiStoryItemCollectionRequest>, IDeepCloneable<HonamiStoryItemCollectionRequest>, IBufferMessage
	{
		// Token: 0x0600AC28 RID: 44072 RVA: 0x0019E679 File Offset: 0x0019C879
		[NullableContext(1)]
		public static HonamiStoryItemCollectionRequest Create()
		{
			return new HonamiStoryItemCollectionRequest();
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x0600AC29 RID: 44073 RVA: 0x0019E680 File Offset: 0x0019C880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x0600AC2A RID: 44074 RVA: 0x0019E683 File Offset: 0x0019C883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryItemCollectionRequest.Descriptor;
			}
		}

		// Token: 0x0600AC2B RID: 44075 RVA: 0x0019E68A File Offset: 0x0019C88A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionRequest()
		{
		}

		// Token: 0x0600AC2C RID: 44076 RVA: 0x0019E69D File Offset: 0x0019C89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionRequest(HonamiStoryItemCollectionRequest other) : this()
		{
			this.honamiStoryItemCollectionId_ = other.honamiStoryItemCollectionId_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC2D RID: 44077 RVA: 0x0019E6D3 File Offset: 0x0019C8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionRequest Clone()
		{
			return new HonamiStoryItemCollectionRequest(this);
		}

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x0600AC2E RID: 44078 RVA: 0x0019E6DB File Offset: 0x0019C8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HonamiStoryItemCollectionId
		{
			get
			{
				return this.honamiStoryItemCollectionId_;
			}
		}

		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x0600AC2F RID: 44079 RVA: 0x0019E6E3 File Offset: 0x0019C8E3
		// (set) Token: 0x0600AC30 RID: 44080 RVA: 0x0019E6EB File Offset: 0x0019C8EB
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

		// Token: 0x0600AC31 RID: 44081 RVA: 0x0019E6F4 File Offset: 0x0019C8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryItemCollectionRequest);
		}

		// Token: 0x0600AC32 RID: 44082 RVA: 0x0019E704 File Offset: 0x0019C904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryItemCollectionRequest other)
		{
			return other != null && (other == this || (this.honamiStoryItemCollectionId_.Equals(other.honamiStoryItemCollectionId_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC33 RID: 44083 RVA: 0x0019E754 File Offset: 0x0019C954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.honamiStoryItemCollectionId_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC34 RID: 44084 RVA: 0x0019E7A1 File Offset: 0x0019C9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AC35 RID: 44085 RVA: 0x0019E7AE File Offset: 0x0019C9AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC36 RID: 44086 RVA: 0x0019E7B8 File Offset: 0x0019C9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryItemCollectionId_.WriteTo(ref output, HonamiStoryItemCollectionRequest._repeated_honamiStoryItemCollectionId_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC37 RID: 44087 RVA: 0x0019E808 File Offset: 0x0019CA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.honamiStoryItemCollectionId_.CalculateSize(HonamiStoryItemCollectionRequest._repeated_honamiStoryItemCollectionId_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC38 RID: 44088 RVA: 0x0019E85C File Offset: 0x0019CA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryItemCollectionRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.honamiStoryItemCollectionId_.Add(other.honamiStoryItemCollectionId_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC39 RID: 44089 RVA: 0x0019E8A9 File Offset: 0x0019CAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC3A RID: 44090 RVA: 0x0019E8B4 File Offset: 0x0019CAB4
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
				if (num != 72U && num != 74U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.honamiStoryItemCollectionId_.AddEntriesFrom(ref input, HonamiStoryItemCollectionRequest._repeated_honamiStoryItemCollectionId_codec);
				}
			}
		}

		// Token: 0x04004E6F RID: 20079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E70 RID: 20080
		public const int HonamiStoryItemCollectionIdFieldNumber = 9;

		// Token: 0x04004E71 RID: 20081
		private static readonly FieldCodec<int> _repeated_honamiStoryItemCollectionId_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04004E72 RID: 20082
		private readonly RepeatedField<int> honamiStoryItemCollectionId_ = new RepeatedField<int>();

		// Token: 0x04004E73 RID: 20083
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04004E74 RID: 20084
		private int activityId_;
	}
}
