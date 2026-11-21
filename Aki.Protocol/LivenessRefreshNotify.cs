using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200091F RID: 2335
	[NetMessage(EMessageId.LivenessRefreshNotify)]
	public sealed class LivenessRefreshNotify : IMessage<LivenessRefreshNotify>, IMessage, IEquatable<LivenessRefreshNotify>, IDeepCloneable<LivenessRefreshNotify>, IBufferMessage
	{
		// Token: 0x0600CE48 RID: 52808 RVA: 0x001E67DF File Offset: 0x001E49DF
		[NullableContext(1)]
		public static LivenessRefreshNotify Create()
		{
			return new LivenessRefreshNotify();
		}

		// Token: 0x170029A9 RID: 10665
		// (get) Token: 0x0600CE49 RID: 52809 RVA: 0x001E67E6 File Offset: 0x001E49E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029AA RID: 10666
		// (get) Token: 0x0600CE4A RID: 52810 RVA: 0x001E67E9 File Offset: 0x001E49E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessRefreshNotify.Descriptor;
			}
		}

		// Token: 0x0600CE4B RID: 52811 RVA: 0x001E67F0 File Offset: 0x001E49F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessRefreshNotify()
		{
		}

		// Token: 0x0600CE4C RID: 52812 RVA: 0x001E67F8 File Offset: 0x001E49F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessRefreshNotify(LivenessRefreshNotify other) : this()
		{
			this.livenessInfo_ = ((other.livenessInfo_ != null) ? other.livenessInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE4D RID: 52813 RVA: 0x001E682D File Offset: 0x001E4A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessRefreshNotify Clone()
		{
			return new LivenessRefreshNotify(this);
		}

		// Token: 0x170029AB RID: 10667
		// (get) Token: 0x0600CE4E RID: 52814 RVA: 0x001E6835 File Offset: 0x001E4A35
		// (set) Token: 0x0600CE4F RID: 52815 RVA: 0x001E683D File Offset: 0x001E4A3D
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

		// Token: 0x0600CE50 RID: 52816 RVA: 0x001E6846 File Offset: 0x001E4A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessRefreshNotify);
		}

		// Token: 0x0600CE51 RID: 52817 RVA: 0x001E6854 File Offset: 0x001E4A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessRefreshNotify other)
		{
			return other != null && (other == this || (object.Equals(this.LivenessInfo, other.LivenessInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE52 RID: 52818 RVA: 0x001E6888 File Offset: 0x001E4A88
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

		// Token: 0x0600CE53 RID: 52819 RVA: 0x001E68C4 File Offset: 0x001E4AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CE54 RID: 52820 RVA: 0x001E68D1 File Offset: 0x001E4AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE55 RID: 52821 RVA: 0x001E68DA File Offset: 0x001E4ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.livenessInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.LivenessInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE56 RID: 52822 RVA: 0x001E690C File Offset: 0x001E4B0C
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

		// Token: 0x0600CE57 RID: 52823 RVA: 0x001E694C File Offset: 0x001E4B4C
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

		// Token: 0x0600CE58 RID: 52824 RVA: 0x001E69A0 File Offset: 0x001E4BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE59 RID: 52825 RVA: 0x001E69AC File Offset: 0x001E4BAC
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
				if (num != 74U)
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

		// Token: 0x0400578F RID: 22415
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005790 RID: 22416
		public const int LivenessInfoFieldNumber = 9;

		// Token: 0x04005791 RID: 22417
		private LivenessInfo livenessInfo_;
	}
}
