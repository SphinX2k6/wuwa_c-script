using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200076B RID: 1899
	[NetMessage(EMessageId.HonamiStoryBagOperateRequest)]
	public sealed class HonamiStoryBagOperateRequest : IMessage<HonamiStoryBagOperateRequest>, IMessage, IEquatable<HonamiStoryBagOperateRequest>, IDeepCloneable<HonamiStoryBagOperateRequest>, IBufferMessage
	{
		// Token: 0x0600ABC2 RID: 43970 RVA: 0x0019D246 File Offset: 0x0019B446
		[NullableContext(1)]
		public static HonamiStoryBagOperateRequest Create()
		{
			return new HonamiStoryBagOperateRequest();
		}

		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x0600ABC3 RID: 43971 RVA: 0x0019D24D File Offset: 0x0019B44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x0600ABC4 RID: 43972 RVA: 0x0019D250 File Offset: 0x0019B450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagOperateRequest.Descriptor;
			}
		}

		// Token: 0x0600ABC5 RID: 43973 RVA: 0x0019D257 File Offset: 0x0019B457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagOperateRequest()
		{
		}

		// Token: 0x0600ABC6 RID: 43974 RVA: 0x0019D26A File Offset: 0x0019B46A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagOperateRequest(HonamiStoryBagOperateRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.honamiStoryBagUpdateContext_ = other.honamiStoryBagUpdateContext_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ABC7 RID: 43975 RVA: 0x0019D2A0 File Offset: 0x0019B4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagOperateRequest Clone()
		{
			return new HonamiStoryBagOperateRequest(this);
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x0600ABC8 RID: 43976 RVA: 0x0019D2A8 File Offset: 0x0019B4A8
		// (set) Token: 0x0600ABC9 RID: 43977 RVA: 0x0019D2B0 File Offset: 0x0019B4B0
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

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x0600ABCA RID: 43978 RVA: 0x0019D2B9 File Offset: 0x0019B4B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryBagUpdateContext> HonamiStoryBagUpdateContext
		{
			get
			{
				return this.honamiStoryBagUpdateContext_;
			}
		}

		// Token: 0x0600ABCB RID: 43979 RVA: 0x0019D2C1 File Offset: 0x0019B4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagOperateRequest);
		}

		// Token: 0x0600ABCC RID: 43980 RVA: 0x0019D2D0 File Offset: 0x0019B4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagOperateRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.honamiStoryBagUpdateContext_.Equals(other.honamiStoryBagUpdateContext_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ABCD RID: 43981 RVA: 0x0019D320 File Offset: 0x0019B520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.honamiStoryBagUpdateContext_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ABCE RID: 43982 RVA: 0x0019D36D File Offset: 0x0019B56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ABCF RID: 43983 RVA: 0x0019D37A File Offset: 0x0019B57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABD0 RID: 43984 RVA: 0x0019D384 File Offset: 0x0019B584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			this.honamiStoryBagUpdateContext_.WriteTo(ref output, HonamiStoryBagOperateRequest._repeated_honamiStoryBagUpdateContext_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ABD1 RID: 43985 RVA: 0x0019D3D4 File Offset: 0x0019B5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.honamiStoryBagUpdateContext_.CalculateSize(HonamiStoryBagOperateRequest._repeated_honamiStoryBagUpdateContext_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ABD2 RID: 43986 RVA: 0x0019D428 File Offset: 0x0019B628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryBagOperateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.honamiStoryBagUpdateContext_.Add(other.honamiStoryBagUpdateContext_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ABD3 RID: 43987 RVA: 0x0019D475 File Offset: 0x0019B675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABD4 RID: 43988 RVA: 0x0019D480 File Offset: 0x0019B680
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
				if (num != 40U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.honamiStoryBagUpdateContext_.AddEntriesFrom(ref input, HonamiStoryBagOperateRequest._repeated_honamiStoryBagUpdateContext_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004DEC RID: 19948
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DED RID: 19949
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x04004DEE RID: 19950
		private int activityId_;

		// Token: 0x04004DEF RID: 19951
		public const int HonamiStoryBagUpdateContextFieldNumber = 12;

		// Token: 0x04004DF0 RID: 19952
		private static readonly FieldCodec<HonamiStoryBagUpdateContext> _repeated_honamiStoryBagUpdateContext_codec = FieldCodec.ForMessage<HonamiStoryBagUpdateContext>(98U, Aki.Protocol.HonamiStoryBagUpdateContext.Parser);

		// Token: 0x04004DF1 RID: 19953
		private readonly RepeatedField<HonamiStoryBagUpdateContext> honamiStoryBagUpdateContext_ = new RepeatedField<HonamiStoryBagUpdateContext>();
	}
}
