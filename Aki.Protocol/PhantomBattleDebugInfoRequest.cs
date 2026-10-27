using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C79 RID: 3193
	[NetMessage(EMessageId.PhantomBattleDebugInfoRequest)]
	public sealed class PhantomBattleDebugInfoRequest : IMessage<PhantomBattleDebugInfoRequest>, IMessage, IEquatable<PhantomBattleDebugInfoRequest>, IDeepCloneable<PhantomBattleDebugInfoRequest>, IBufferMessage
	{
		// Token: 0x060114F2 RID: 70898 RVA: 0x00288DEC File Offset: 0x00286FEC
		[NullableContext(1)]
		public static PhantomBattleDebugInfoRequest Create()
		{
			return new PhantomBattleDebugInfoRequest();
		}

		// Token: 0x17003949 RID: 14665
		// (get) Token: 0x060114F3 RID: 70899 RVA: 0x00288DF3 File Offset: 0x00286FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700394A RID: 14666
		// (get) Token: 0x060114F4 RID: 70900 RVA: 0x00288DF6 File Offset: 0x00286FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDebugInfoRequest.Descriptor;
			}
		}

		// Token: 0x060114F5 RID: 70901 RVA: 0x00288DFD File Offset: 0x00286FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugInfoRequest()
		{
		}

		// Token: 0x060114F6 RID: 70902 RVA: 0x00288E05 File Offset: 0x00287005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugInfoRequest(PhantomBattleDebugInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060114F7 RID: 70903 RVA: 0x00288E1E File Offset: 0x0028701E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugInfoRequest Clone()
		{
			return new PhantomBattleDebugInfoRequest(this);
		}

		// Token: 0x060114F8 RID: 70904 RVA: 0x00288E26 File Offset: 0x00287026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDebugInfoRequest);
		}

		// Token: 0x060114F9 RID: 70905 RVA: 0x00288E34 File Offset: 0x00287034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDebugInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060114FA RID: 70906 RVA: 0x00288E54 File Offset: 0x00287054
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

		// Token: 0x060114FB RID: 70907 RVA: 0x00288E7A File Offset: 0x0028707A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060114FC RID: 70908 RVA: 0x00288E87 File Offset: 0x00287087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060114FD RID: 70909 RVA: 0x00288E90 File Offset: 0x00287090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060114FE RID: 70910 RVA: 0x00288EA8 File Offset: 0x002870A8
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

		// Token: 0x060114FF RID: 70911 RVA: 0x00288ECE File Offset: 0x002870CE
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

		// Token: 0x06011500 RID: 70912 RVA: 0x00288EEB File Offset: 0x002870EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011501 RID: 70913 RVA: 0x00288EF4 File Offset: 0x002870F4
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

		// Token: 0x04006D76 RID: 28022
		private UnknownFieldSet _unknownFields;
	}
}
