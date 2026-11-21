using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200100B RID: 4107
	[NetMessage(EMessageId.RogueTowerTrialReChallengeNotify)]
	public sealed class RogueTowerTrialReChallengeNotify : IMessage<RogueTowerTrialReChallengeNotify>, IMessage, IEquatable<RogueTowerTrialReChallengeNotify>, IDeepCloneable<RogueTowerTrialReChallengeNotify>, IBufferMessage
	{
		// Token: 0x06015FCF RID: 90063 RVA: 0x00332D8C File Offset: 0x00330F8C
		[NullableContext(1)]
		public static RogueTowerTrialReChallengeNotify Create()
		{
			return new RogueTowerTrialReChallengeNotify();
		}

		// Token: 0x17004987 RID: 18823
		// (get) Token: 0x06015FD0 RID: 90064 RVA: 0x00332D93 File Offset: 0x00330F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004988 RID: 18824
		// (get) Token: 0x06015FD1 RID: 90065 RVA: 0x00332D96 File Offset: 0x00330F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialReChallengeNotify.Descriptor;
			}
		}

		// Token: 0x06015FD2 RID: 90066 RVA: 0x00332D9D File Offset: 0x00330F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeNotify()
		{
		}

		// Token: 0x06015FD3 RID: 90067 RVA: 0x00332DA5 File Offset: 0x00330FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeNotify(RogueTowerTrialReChallengeNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015FD4 RID: 90068 RVA: 0x00332DBE File Offset: 0x00330FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeNotify Clone()
		{
			return new RogueTowerTrialReChallengeNotify(this);
		}

		// Token: 0x06015FD5 RID: 90069 RVA: 0x00332DC6 File Offset: 0x00330FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialReChallengeNotify);
		}

		// Token: 0x06015FD6 RID: 90070 RVA: 0x00332DD4 File Offset: 0x00330FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialReChallengeNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06015FD7 RID: 90071 RVA: 0x00332DF4 File Offset: 0x00330FF4
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

		// Token: 0x06015FD8 RID: 90072 RVA: 0x00332E1A File Offset: 0x0033101A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015FD9 RID: 90073 RVA: 0x00332E27 File Offset: 0x00331027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015FDA RID: 90074 RVA: 0x00332E30 File Offset: 0x00331030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015FDB RID: 90075 RVA: 0x00332E48 File Offset: 0x00331048
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

		// Token: 0x06015FDC RID: 90076 RVA: 0x00332E6E File Offset: 0x0033106E
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

		// Token: 0x06015FDD RID: 90077 RVA: 0x00332E8B File Offset: 0x0033108B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015FDE RID: 90078 RVA: 0x00332E94 File Offset: 0x00331094
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

		// Token: 0x04008456 RID: 33878
		private UnknownFieldSet _unknownFields;
	}
}
