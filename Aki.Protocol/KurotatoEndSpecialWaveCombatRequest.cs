using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000883 RID: 2179
	[NetMessage(EMessageId.KurotatoEndSpecialWaveCombatRequest)]
	public sealed class KurotatoEndSpecialWaveCombatRequest : IMessage<KurotatoEndSpecialWaveCombatRequest>, IMessage, IEquatable<KurotatoEndSpecialWaveCombatRequest>, IDeepCloneable<KurotatoEndSpecialWaveCombatRequest>, IBufferMessage
	{
		// Token: 0x0600C21D RID: 49693 RVA: 0x001CD0A1 File Offset: 0x001CB2A1
		[NullableContext(1)]
		public static KurotatoEndSpecialWaveCombatRequest Create()
		{
			return new KurotatoEndSpecialWaveCombatRequest();
		}

		// Token: 0x17002736 RID: 10038
		// (get) Token: 0x0600C21E RID: 49694 RVA: 0x001CD0A8 File Offset: 0x001CB2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002737 RID: 10039
		// (get) Token: 0x0600C21F RID: 49695 RVA: 0x001CD0AB File Offset: 0x001CB2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoEndSpecialWaveCombatRequest.Descriptor;
			}
		}

		// Token: 0x0600C220 RID: 49696 RVA: 0x001CD0B2 File Offset: 0x001CB2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndSpecialWaveCombatRequest()
		{
		}

		// Token: 0x0600C221 RID: 49697 RVA: 0x001CD0BA File Offset: 0x001CB2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndSpecialWaveCombatRequest(KurotatoEndSpecialWaveCombatRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C222 RID: 49698 RVA: 0x001CD0D3 File Offset: 0x001CB2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndSpecialWaveCombatRequest Clone()
		{
			return new KurotatoEndSpecialWaveCombatRequest(this);
		}

		// Token: 0x0600C223 RID: 49699 RVA: 0x001CD0DB File Offset: 0x001CB2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoEndSpecialWaveCombatRequest);
		}

		// Token: 0x0600C224 RID: 49700 RVA: 0x001CD0E9 File Offset: 0x001CB2E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoEndSpecialWaveCombatRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C225 RID: 49701 RVA: 0x001CD108 File Offset: 0x001CB308
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

		// Token: 0x0600C226 RID: 49702 RVA: 0x001CD12E File Offset: 0x001CB32E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C227 RID: 49703 RVA: 0x001CD13B File Offset: 0x001CB33B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C228 RID: 49704 RVA: 0x001CD144 File Offset: 0x001CB344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C229 RID: 49705 RVA: 0x001CD15C File Offset: 0x001CB35C
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

		// Token: 0x0600C22A RID: 49706 RVA: 0x001CD182 File Offset: 0x001CB382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoEndSpecialWaveCombatRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C22B RID: 49707 RVA: 0x001CD19F File Offset: 0x001CB39F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C22C RID: 49708 RVA: 0x001CD1A8 File Offset: 0x001CB3A8
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

		// Token: 0x04005469 RID: 21609
		private UnknownFieldSet _unknownFields;
	}
}
