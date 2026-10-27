using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200141E RID: 5150
	[NetMessage(EMessageId.TrapDefenseCurChallengeInfoRequest)]
	public sealed class TrapDefenseCurChallengeInfoRequest : IMessage<TrapDefenseCurChallengeInfoRequest>, IMessage, IEquatable<TrapDefenseCurChallengeInfoRequest>, IDeepCloneable<TrapDefenseCurChallengeInfoRequest>, IBufferMessage
	{
		// Token: 0x0601B4C4 RID: 111812 RVA: 0x003F4AF3 File Offset: 0x003F2CF3
		[NullableContext(1)]
		public static TrapDefenseCurChallengeInfoRequest Create()
		{
			return new TrapDefenseCurChallengeInfoRequest();
		}

		// Token: 0x17005C16 RID: 23574
		// (get) Token: 0x0601B4C5 RID: 111813 RVA: 0x003F4AFA File Offset: 0x003F2CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C17 RID: 23575
		// (get) Token: 0x0601B4C6 RID: 111814 RVA: 0x003F4AFD File Offset: 0x003F2CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseCurChallengeInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601B4C7 RID: 111815 RVA: 0x003F4B04 File Offset: 0x003F2D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCurChallengeInfoRequest()
		{
		}

		// Token: 0x0601B4C8 RID: 111816 RVA: 0x003F4B0C File Offset: 0x003F2D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCurChallengeInfoRequest(TrapDefenseCurChallengeInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B4C9 RID: 111817 RVA: 0x003F4B25 File Offset: 0x003F2D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseCurChallengeInfoRequest Clone()
		{
			return new TrapDefenseCurChallengeInfoRequest(this);
		}

		// Token: 0x0601B4CA RID: 111818 RVA: 0x003F4B2D File Offset: 0x003F2D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseCurChallengeInfoRequest);
		}

		// Token: 0x0601B4CB RID: 111819 RVA: 0x003F4B3B File Offset: 0x003F2D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseCurChallengeInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B4CC RID: 111820 RVA: 0x003F4B5C File Offset: 0x003F2D5C
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

		// Token: 0x0601B4CD RID: 111821 RVA: 0x003F4B82 File Offset: 0x003F2D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B4CE RID: 111822 RVA: 0x003F4B8F File Offset: 0x003F2D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B4CF RID: 111823 RVA: 0x003F4B98 File Offset: 0x003F2D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B4D0 RID: 111824 RVA: 0x003F4BB0 File Offset: 0x003F2DB0
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

		// Token: 0x0601B4D1 RID: 111825 RVA: 0x003F4BD6 File Offset: 0x003F2DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseCurChallengeInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B4D2 RID: 111826 RVA: 0x003F4BF3 File Offset: 0x003F2DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B4D3 RID: 111827 RVA: 0x003F4BFC File Offset: 0x003F2DFC
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

		// Token: 0x04009DCC RID: 40396
		private UnknownFieldSet _unknownFields;
	}
}
