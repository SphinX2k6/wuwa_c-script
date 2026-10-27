using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200101B RID: 4123
	[NetMessage(EMessageId.RogueTowerTrialReChallengeNotify)]
	public sealed class RogueTowerTrialReChallengeNotify : IMessage<RogueTowerTrialReChallengeNotify>, IMessage, IEquatable<RogueTowerTrialReChallengeNotify>, IDeepCloneable<RogueTowerTrialReChallengeNotify>, IBufferMessage
	{
		// Token: 0x060160B4 RID: 90292 RVA: 0x0033444D File Offset: 0x0033264D
		[NullableContext(1)]
		public static RogueTowerTrialReChallengeNotify Create()
		{
			return new RogueTowerTrialReChallengeNotify();
		}

		// Token: 0x170049B1 RID: 18865
		// (get) Token: 0x060160B5 RID: 90293 RVA: 0x00334454 File Offset: 0x00332654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049B2 RID: 18866
		// (get) Token: 0x060160B6 RID: 90294 RVA: 0x00334457 File Offset: 0x00332657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialReChallengeNotify.Descriptor;
			}
		}

		// Token: 0x060160B7 RID: 90295 RVA: 0x0033445E File Offset: 0x0033265E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeNotify()
		{
		}

		// Token: 0x060160B8 RID: 90296 RVA: 0x00334466 File Offset: 0x00332666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeNotify(RogueTowerTrialReChallengeNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060160B9 RID: 90297 RVA: 0x0033447F File Offset: 0x0033267F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeNotify Clone()
		{
			return new RogueTowerTrialReChallengeNotify(this);
		}

		// Token: 0x060160BA RID: 90298 RVA: 0x00334487 File Offset: 0x00332687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialReChallengeNotify);
		}

		// Token: 0x060160BB RID: 90299 RVA: 0x00334495 File Offset: 0x00332695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialReChallengeNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060160BC RID: 90300 RVA: 0x003344B4 File Offset: 0x003326B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060160BD RID: 90301 RVA: 0x003344DA File Offset: 0x003326DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060160BE RID: 90302 RVA: 0x003344E7 File Offset: 0x003326E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060160BF RID: 90303 RVA: 0x003344F0 File Offset: 0x003326F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060160C0 RID: 90304 RVA: 0x00334508 File Offset: 0x00332708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060160C1 RID: 90305 RVA: 0x0033452E File Offset: 0x0033272E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialReChallengeNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060160C2 RID: 90306 RVA: 0x0033454B File Offset: 0x0033274B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060160C3 RID: 90307 RVA: 0x00334554 File Offset: 0x00332754
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400842C RID: 33836
		private UnknownFieldSet _unknownFields;
	}
}
