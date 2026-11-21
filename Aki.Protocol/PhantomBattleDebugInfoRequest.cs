using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C69 RID: 3177
	[NetMessage(EMessageId.PhantomBattleDebugInfoRequest)]
	public sealed class PhantomBattleDebugInfoRequest : IMessage<PhantomBattleDebugInfoRequest>, IMessage, IEquatable<PhantomBattleDebugInfoRequest>, IDeepCloneable<PhantomBattleDebugInfoRequest>, IBufferMessage
	{
		// Token: 0x060113F2 RID: 70642 RVA: 0x0028707C File Offset: 0x0028527C
		[NullableContext(1)]
		public static PhantomBattleDebugInfoRequest Create()
		{
			return new PhantomBattleDebugInfoRequest();
		}

		// Token: 0x17003912 RID: 14610
		// (get) Token: 0x060113F3 RID: 70643 RVA: 0x00287083 File Offset: 0x00285283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x060113F4 RID: 70644 RVA: 0x00287086 File Offset: 0x00285286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDebugInfoRequest.Descriptor;
			}
		}

		// Token: 0x060113F5 RID: 70645 RVA: 0x0028708D File Offset: 0x0028528D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugInfoRequest()
		{
		}

		// Token: 0x060113F6 RID: 70646 RVA: 0x00287095 File Offset: 0x00285295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugInfoRequest(PhantomBattleDebugInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060113F7 RID: 70647 RVA: 0x002870AE File Offset: 0x002852AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugInfoRequest Clone()
		{
			return new PhantomBattleDebugInfoRequest(this);
		}

		// Token: 0x060113F8 RID: 70648 RVA: 0x002870B6 File Offset: 0x002852B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDebugInfoRequest);
		}

		// Token: 0x060113F9 RID: 70649 RVA: 0x002870C4 File Offset: 0x002852C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDebugInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060113FA RID: 70650 RVA: 0x002870E4 File Offset: 0x002852E4
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

		// Token: 0x060113FB RID: 70651 RVA: 0x0028710A File Offset: 0x0028530A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060113FC RID: 70652 RVA: 0x00287117 File Offset: 0x00285317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060113FD RID: 70653 RVA: 0x00287120 File Offset: 0x00285320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060113FE RID: 70654 RVA: 0x00287138 File Offset: 0x00285338
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

		// Token: 0x060113FF RID: 70655 RVA: 0x0028715E File Offset: 0x0028535E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDebugInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011400 RID: 70656 RVA: 0x0028717B File Offset: 0x0028537B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011401 RID: 70657 RVA: 0x00287184 File Offset: 0x00285384
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

		// Token: 0x04006D8A RID: 28042
		private UnknownFieldSet _unknownFields;
	}
}
