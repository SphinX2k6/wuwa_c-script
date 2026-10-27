using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000938 RID: 2360
	[NetMessage(EMessageId.LivenessUpdateNotify)]
	public sealed class LivenessUpdateNotify : IMessage<LivenessUpdateNotify>, IMessage, IEquatable<LivenessUpdateNotify>, IDeepCloneable<LivenessUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600D002 RID: 53250 RVA: 0x001E9E9C File Offset: 0x001E809C
		[NullableContext(1)]
		public static LivenessUpdateNotify Create()
		{
			return new LivenessUpdateNotify();
		}

		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x0600D003 RID: 53251 RVA: 0x001E9EA3 File Offset: 0x001E80A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A08 RID: 10760
		// (get) Token: 0x0600D004 RID: 53252 RVA: 0x001E9EA6 File Offset: 0x001E80A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600D005 RID: 53253 RVA: 0x001E9EAD File Offset: 0x001E80AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessUpdateNotify()
		{
		}

		// Token: 0x0600D006 RID: 53254 RVA: 0x001E9EB5 File Offset: 0x001E80B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessUpdateNotify(LivenessUpdateNotify other) : this()
		{
			this.livenessInfo_ = ((other.livenessInfo_ != null) ? other.livenessInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D007 RID: 53255 RVA: 0x001E9EEA File Offset: 0x001E80EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessUpdateNotify Clone()
		{
			return new LivenessUpdateNotify(this);
		}

		// Token: 0x17002A09 RID: 10761
		// (get) Token: 0x0600D008 RID: 53256 RVA: 0x001E9EF2 File Offset: 0x001E80F2
		// (set) Token: 0x0600D009 RID: 53257 RVA: 0x001E9EFA File Offset: 0x001E80FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessInfo LivenessInfo
		{
			get
			{
				return this.livenessInfo_;
			}
			set
			{
				this.livenessInfo_ = value;
			}
		}

		// Token: 0x0600D00A RID: 53258 RVA: 0x001E9F03 File Offset: 0x001E8103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessUpdateNotify);
		}

		// Token: 0x0600D00B RID: 53259 RVA: 0x001E9F11 File Offset: 0x001E8111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.LivenessInfo, other.LivenessInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D00C RID: 53260 RVA: 0x001E9F44 File Offset: 0x001E8144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.livenessInfo_ != null)
			{
				num ^= this.LivenessInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D00D RID: 53261 RVA: 0x001E9F80 File Offset: 0x001E8180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D00E RID: 53262 RVA: 0x001E9F8D File Offset: 0x001E818D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D00F RID: 53263 RVA: 0x001E9F96 File Offset: 0x001E8196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.livenessInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.LivenessInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D010 RID: 53264 RVA: 0x001E9FC8 File Offset: 0x001E81C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.livenessInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LivenessInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D011 RID: 53265 RVA: 0x001EA008 File Offset: 0x001E8208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivenessUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.livenessInfo_ != null)
			{
				if (this.livenessInfo_ == null)
				{
					this.LivenessInfo = new LivenessInfo();
				}
				this.LivenessInfo.MergeFrom(other.LivenessInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D012 RID: 53266 RVA: 0x001EA05C File Offset: 0x001E825C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D013 RID: 53267 RVA: 0x001EA068 File Offset: 0x001E8268
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.livenessInfo_ == null)
					{
						this.LivenessInfo = new LivenessInfo();
					}
					input.ReadMessage(this.LivenessInfo);
				}
			}
		}

		// Token: 0x040057B1 RID: 22449
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057B2 RID: 22450
		public const int LivenessInfoFieldNumber = 8;

		// Token: 0x040057B3 RID: 22451
		private LivenessInfo livenessInfo_;
	}
}
