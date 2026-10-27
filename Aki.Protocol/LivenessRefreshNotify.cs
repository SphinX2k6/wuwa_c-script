using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000930 RID: 2352
	[NetMessage(EMessageId.LivenessRefreshNotify)]
	public sealed class LivenessRefreshNotify : IMessage<LivenessRefreshNotify>, IMessage, IEquatable<LivenessRefreshNotify>, IDeepCloneable<LivenessRefreshNotify>, IBufferMessage
	{
		// Token: 0x0600CF64 RID: 53092 RVA: 0x001E8AB3 File Offset: 0x001E6CB3
		[NullableContext(1)]
		public static LivenessRefreshNotify Create()
		{
			return new LivenessRefreshNotify();
		}

		// Token: 0x170029E8 RID: 10728
		// (get) Token: 0x0600CF65 RID: 53093 RVA: 0x001E8ABA File Offset: 0x001E6CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029E9 RID: 10729
		// (get) Token: 0x0600CF66 RID: 53094 RVA: 0x001E8ABD File Offset: 0x001E6CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessRefreshNotify.Descriptor;
			}
		}

		// Token: 0x0600CF67 RID: 53095 RVA: 0x001E8AC4 File Offset: 0x001E6CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessRefreshNotify()
		{
		}

		// Token: 0x0600CF68 RID: 53096 RVA: 0x001E8ACC File Offset: 0x001E6CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessRefreshNotify(LivenessRefreshNotify other) : this()
		{
			this.livenessInfo_ = ((other.livenessInfo_ != null) ? other.livenessInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF69 RID: 53097 RVA: 0x001E8B01 File Offset: 0x001E6D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessRefreshNotify Clone()
		{
			return new LivenessRefreshNotify(this);
		}

		// Token: 0x170029EA RID: 10730
		// (get) Token: 0x0600CF6A RID: 53098 RVA: 0x001E8B09 File Offset: 0x001E6D09
		// (set) Token: 0x0600CF6B RID: 53099 RVA: 0x001E8B11 File Offset: 0x001E6D11
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

		// Token: 0x0600CF6C RID: 53100 RVA: 0x001E8B1A File Offset: 0x001E6D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessRefreshNotify);
		}

		// Token: 0x0600CF6D RID: 53101 RVA: 0x001E8B28 File Offset: 0x001E6D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessRefreshNotify other)
		{
			return other != null && (other == this || (object.Equals(this.LivenessInfo, other.LivenessInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF6E RID: 53102 RVA: 0x001E8B5C File Offset: 0x001E6D5C
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

		// Token: 0x0600CF6F RID: 53103 RVA: 0x001E8B98 File Offset: 0x001E6D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF70 RID: 53104 RVA: 0x001E8BA5 File Offset: 0x001E6DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF71 RID: 53105 RVA: 0x001E8BAE File Offset: 0x001E6DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.livenessInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.LivenessInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF72 RID: 53106 RVA: 0x001E8BE0 File Offset: 0x001E6DE0
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

		// Token: 0x0600CF73 RID: 53107 RVA: 0x001E8C20 File Offset: 0x001E6E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivenessRefreshNotify other)
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

		// Token: 0x0600CF74 RID: 53108 RVA: 0x001E8C74 File Offset: 0x001E6E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF75 RID: 53109 RVA: 0x001E8C80 File Offset: 0x001E6E80
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
				if (num != 122U)
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

		// Token: 0x04005788 RID: 22408
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005789 RID: 22409
		public const int LivenessInfoFieldNumber = 15;

		// Token: 0x0400578A RID: 22410
		private LivenessInfo livenessInfo_;
	}
}
