using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000894 RID: 2196
	[NetMessage(EMessageId.KurotatoEndSpecialWaveCombatRequest)]
	public sealed class KurotatoEndSpecialWaveCombatRequest : IMessage<KurotatoEndSpecialWaveCombatRequest>, IMessage, IEquatable<KurotatoEndSpecialWaveCombatRequest>, IDeepCloneable<KurotatoEndSpecialWaveCombatRequest>, IBufferMessage
	{
		// Token: 0x0600C339 RID: 49977 RVA: 0x001CF389 File Offset: 0x001CD589
		[NullableContext(1)]
		public static KurotatoEndSpecialWaveCombatRequest Create()
		{
			return new KurotatoEndSpecialWaveCombatRequest();
		}

		// Token: 0x17002775 RID: 10101
		// (get) Token: 0x0600C33A RID: 49978 RVA: 0x001CF390 File Offset: 0x001CD590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002776 RID: 10102
		// (get) Token: 0x0600C33B RID: 49979 RVA: 0x001CF393 File Offset: 0x001CD593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoEndSpecialWaveCombatRequest.Descriptor;
			}
		}

		// Token: 0x0600C33C RID: 49980 RVA: 0x001CF39A File Offset: 0x001CD59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndSpecialWaveCombatRequest()
		{
		}

		// Token: 0x0600C33D RID: 49981 RVA: 0x001CF3A2 File Offset: 0x001CD5A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndSpecialWaveCombatRequest(KurotatoEndSpecialWaveCombatRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C33E RID: 49982 RVA: 0x001CF3BB File Offset: 0x001CD5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoEndSpecialWaveCombatRequest Clone()
		{
			return new KurotatoEndSpecialWaveCombatRequest(this);
		}

		// Token: 0x0600C33F RID: 49983 RVA: 0x001CF3C3 File Offset: 0x001CD5C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoEndSpecialWaveCombatRequest);
		}

		// Token: 0x0600C340 RID: 49984 RVA: 0x001CF3D1 File Offset: 0x001CD5D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoEndSpecialWaveCombatRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C341 RID: 49985 RVA: 0x001CF3F0 File Offset: 0x001CD5F0
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

		// Token: 0x0600C342 RID: 49986 RVA: 0x001CF416 File Offset: 0x001CD616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C343 RID: 49987 RVA: 0x001CF423 File Offset: 0x001CD623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C344 RID: 49988 RVA: 0x001CF42C File Offset: 0x001CD62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C345 RID: 49989 RVA: 0x001CF444 File Offset: 0x001CD644
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

		// Token: 0x0600C346 RID: 49990 RVA: 0x001CF46A File Offset: 0x001CD66A
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

		// Token: 0x0600C347 RID: 49991 RVA: 0x001CF487 File Offset: 0x001CD687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C348 RID: 49992 RVA: 0x001CF490 File Offset: 0x001CD690
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

		// Token: 0x04005462 RID: 21602
		private UnknownFieldSet _unknownFields;
	}
}
