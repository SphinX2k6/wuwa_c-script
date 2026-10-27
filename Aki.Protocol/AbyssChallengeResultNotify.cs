using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200001B RID: 27
	[NetMessage(EMessageId.AbyssChallengeResultNotify)]
	public sealed class AbyssChallengeResultNotify : IMessage<AbyssChallengeResultNotify>, IMessage, IEquatable<AbyssChallengeResultNotify>, IDeepCloneable<AbyssChallengeResultNotify>, IBufferMessage
	{
		// Token: 0x06001087 RID: 4231 RVA: 0x0002E2C0 File Offset: 0x0002C4C0
		[NullableContext(1)]
		public static AbyssChallengeResultNotify Create()
		{
			return new AbyssChallengeResultNotify();
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x0002E2C7 File Offset: 0x0002C4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x0002E2CA File Offset: 0x0002C4CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeResultNotify.Descriptor;
			}
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0002E2D1 File Offset: 0x0002C4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultNotify()
		{
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0002E2D9 File Offset: 0x0002C4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultNotify(AbyssChallengeResultNotify other) : this()
		{
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0002E30E File Offset: 0x0002C50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultNotify Clone()
		{
			return new AbyssChallengeResultNotify(this);
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x0002E316 File Offset: 0x0002C516
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x0002E31E File Offset: 0x0002C51E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultInfo Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0002E327 File Offset: 0x0002C527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeResultNotify);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0002E335 File Offset: 0x0002C535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeResultNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0002E368 File Offset: 0x0002C568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.result_ != null)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0002E3A4 File Offset: 0x0002C5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0002E3B1 File Offset: 0x0002C5B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0002E3BA File Offset: 0x0002C5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.result_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0002E3EC File Offset: 0x0002C5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.result_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Result);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0002E42C File Offset: 0x0002C62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengeResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.result_ != null)
			{
				if (this.result_ == null)
				{
					this.Result = new AbyssChallengeResultInfo();
				}
				this.Result.MergeFrom(other.Result);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0002E480 File Offset: 0x0002C680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0002E48C File Offset: 0x0002C68C
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.result_ == null)
					{
						this.Result = new AbyssChallengeResultInfo();
					}
					input.ReadMessage(this.Result);
				}
			}
		}

		// Token: 0x04001F1A RID: 7962
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F1B RID: 7963
		public const int ResultFieldNumber = 3;

		// Token: 0x04001F1C RID: 7964
		private AbyssChallengeResultInfo result_;
	}
}
