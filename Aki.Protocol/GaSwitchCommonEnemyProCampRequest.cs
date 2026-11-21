using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200069F RID: 1695
	[NetMessage(EMessageId.GaSwitchCommonEnemyProCampRequest)]
	public sealed class GaSwitchCommonEnemyProCampRequest : IMessage<GaSwitchCommonEnemyProCampRequest>, IMessage, IEquatable<GaSwitchCommonEnemyProCampRequest>, IDeepCloneable<GaSwitchCommonEnemyProCampRequest>, IBufferMessage
	{
		// Token: 0x06009BE8 RID: 39912 RVA: 0x0017BC2B File Offset: 0x00179E2B
		[NullableContext(1)]
		public static GaSwitchCommonEnemyProCampRequest Create()
		{
			return new GaSwitchCommonEnemyProCampRequest();
		}

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x06009BE9 RID: 39913 RVA: 0x0017BC32 File Offset: 0x00179E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x06009BEA RID: 39914 RVA: 0x0017BC35 File Offset: 0x00179E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GaSwitchCommonEnemyProCampRequest.Descriptor;
			}
		}

		// Token: 0x06009BEB RID: 39915 RVA: 0x0017BC3C File Offset: 0x00179E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaSwitchCommonEnemyProCampRequest()
		{
		}

		// Token: 0x06009BEC RID: 39916 RVA: 0x0017BC44 File Offset: 0x00179E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaSwitchCommonEnemyProCampRequest(GaSwitchCommonEnemyProCampRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009BED RID: 39917 RVA: 0x0017BC5D File Offset: 0x00179E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaSwitchCommonEnemyProCampRequest Clone()
		{
			return new GaSwitchCommonEnemyProCampRequest(this);
		}

		// Token: 0x06009BEE RID: 39918 RVA: 0x0017BC65 File Offset: 0x00179E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GaSwitchCommonEnemyProCampRequest);
		}

		// Token: 0x06009BEF RID: 39919 RVA: 0x0017BC73 File Offset: 0x00179E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GaSwitchCommonEnemyProCampRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009BF0 RID: 39920 RVA: 0x0017BC94 File Offset: 0x00179E94
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

		// Token: 0x06009BF1 RID: 39921 RVA: 0x0017BCBA File Offset: 0x00179EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009BF2 RID: 39922 RVA: 0x0017BCC7 File Offset: 0x00179EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009BF3 RID: 39923 RVA: 0x0017BCD0 File Offset: 0x00179ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009BF4 RID: 39924 RVA: 0x0017BCE8 File Offset: 0x00179EE8
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

		// Token: 0x06009BF5 RID: 39925 RVA: 0x0017BD0E File Offset: 0x00179F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GaSwitchCommonEnemyProCampRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009BF6 RID: 39926 RVA: 0x0017BD2B File Offset: 0x00179F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009BF7 RID: 39927 RVA: 0x0017BD34 File Offset: 0x00179F34
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

		// Token: 0x040049EB RID: 18923
		private UnknownFieldSet _unknownFields;
	}
}
