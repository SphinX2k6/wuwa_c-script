using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000927 RID: 2343
	[NetMessage(EMessageId.LivenessUpdateNotify)]
	public sealed class LivenessUpdateNotify : IMessage<LivenessUpdateNotify>, IMessage, IEquatable<LivenessUpdateNotify>, IDeepCloneable<LivenessUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600CEE6 RID: 52966 RVA: 0x001E7BC8 File Offset: 0x001E5DC8
		[NullableContext(1)]
		public static LivenessUpdateNotify Create()
		{
			return new LivenessUpdateNotify();
		}

		// Token: 0x170029C8 RID: 10696
		// (get) Token: 0x0600CEE7 RID: 52967 RVA: 0x001E7BCF File Offset: 0x001E5DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029C9 RID: 10697
		// (get) Token: 0x0600CEE8 RID: 52968 RVA: 0x001E7BD2 File Offset: 0x001E5DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600CEE9 RID: 52969 RVA: 0x001E7BD9 File Offset: 0x001E5DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessUpdateNotify()
		{
		}

		// Token: 0x0600CEEA RID: 52970 RVA: 0x001E7BE1 File Offset: 0x001E5DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessUpdateNotify(LivenessUpdateNotify other) : this()
		{
			this.livenessInfo_ = ((other.livenessInfo_ != null) ? other.livenessInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CEEB RID: 52971 RVA: 0x001E7C16 File Offset: 0x001E5E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessUpdateNotify Clone()
		{
			return new LivenessUpdateNotify(this);
		}

		// Token: 0x170029CA RID: 10698
		// (get) Token: 0x0600CEEC RID: 52972 RVA: 0x001E7C1E File Offset: 0x001E5E1E
		// (set) Token: 0x0600CEED RID: 52973 RVA: 0x001E7C26 File Offset: 0x001E5E26
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

		// Token: 0x0600CEEE RID: 52974 RVA: 0x001E7C2F File Offset: 0x001E5E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessUpdateNotify);
		}

		// Token: 0x0600CEEF RID: 52975 RVA: 0x001E7C3D File Offset: 0x001E5E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.LivenessInfo, other.LivenessInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CEF0 RID: 52976 RVA: 0x001E7C70 File Offset: 0x001E5E70
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

		// Token: 0x0600CEF1 RID: 52977 RVA: 0x001E7CAC File Offset: 0x001E5EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CEF2 RID: 52978 RVA: 0x001E7CB9 File Offset: 0x001E5EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CEF3 RID: 52979 RVA: 0x001E7CC2 File Offset: 0x001E5EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.livenessInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.LivenessInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CEF4 RID: 52980 RVA: 0x001E7CF4 File Offset: 0x001E5EF4
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

		// Token: 0x0600CEF5 RID: 52981 RVA: 0x001E7D34 File Offset: 0x001E5F34
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

		// Token: 0x0600CEF6 RID: 52982 RVA: 0x001E7D88 File Offset: 0x001E5F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CEF7 RID: 52983 RVA: 0x001E7D94 File Offset: 0x001E5F94
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
				if (num != 98U)
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

		// Token: 0x040057B8 RID: 22456
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057B9 RID: 22457
		public const int LivenessInfoFieldNumber = 12;

		// Token: 0x040057BA RID: 22458
		private LivenessInfo livenessInfo_;
	}
}
