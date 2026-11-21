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
		// Token: 0x060010B2 RID: 4274 RVA: 0x0002E874 File Offset: 0x0002CA74
		[NullableContext(1)]
		public static AbyssChallengeResultNotify Create()
		{
			return new AbyssChallengeResultNotify();
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0002E87B File Offset: 0x0002CA7B
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
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x0002E87E File Offset: 0x0002CA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeResultNotify.Descriptor;
			}
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0002E885 File Offset: 0x0002CA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultNotify()
		{
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0002E88D File Offset: 0x0002CA8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultNotify(AbyssChallengeResultNotify other) : this()
		{
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0002E8C2 File Offset: 0x0002CAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeResultNotify Clone()
		{
			return new AbyssChallengeResultNotify(this);
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x0002E8CA File Offset: 0x0002CACA
		// (set) Token: 0x060010B9 RID: 4281 RVA: 0x0002E8D2 File Offset: 0x0002CAD2
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

		// Token: 0x060010BA RID: 4282 RVA: 0x0002E8DB File Offset: 0x0002CADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeResultNotify);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0002E8E9 File Offset: 0x0002CAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeResultNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0002E91C File Offset: 0x0002CB1C
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

		// Token: 0x060010BD RID: 4285 RVA: 0x0002E958 File Offset: 0x0002CB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0002E965 File Offset: 0x0002CB65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0002E96E File Offset: 0x0002CB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.result_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0002E9A0 File Offset: 0x0002CBA0
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

		// Token: 0x060010C1 RID: 4289 RVA: 0x0002E9E0 File Offset: 0x0002CBE0
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

		// Token: 0x060010C2 RID: 4290 RVA: 0x0002EA34 File Offset: 0x0002CC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0002EA40 File Offset: 0x0002CC40
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
				if (num != 90U)
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

		// Token: 0x04001F70 RID: 8048
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F71 RID: 8049
		public const int ResultFieldNumber = 11;

		// Token: 0x04001F72 RID: 8050
		private AbyssChallengeResultInfo result_;
	}
}
