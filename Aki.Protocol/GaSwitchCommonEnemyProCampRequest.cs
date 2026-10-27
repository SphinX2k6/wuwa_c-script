using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B3 RID: 1715
	[NetMessage(EMessageId.GaSwitchCommonEnemyProCampRequest)]
	public sealed class GaSwitchCommonEnemyProCampRequest : IMessage<GaSwitchCommonEnemyProCampRequest>, IMessage, IEquatable<GaSwitchCommonEnemyProCampRequest>, IDeepCloneable<GaSwitchCommonEnemyProCampRequest>, IBufferMessage
	{
		// Token: 0x06009D3E RID: 40254 RVA: 0x0017E65B File Offset: 0x0017C85B
		[NullableContext(1)]
		public static GaSwitchCommonEnemyProCampRequest Create()
		{
			return new GaSwitchCommonEnemyProCampRequest();
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x06009D3F RID: 40255 RVA: 0x0017E662 File Offset: 0x0017C862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x06009D40 RID: 40256 RVA: 0x0017E665 File Offset: 0x0017C865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GaSwitchCommonEnemyProCampRequest.Descriptor;
			}
		}

		// Token: 0x06009D41 RID: 40257 RVA: 0x0017E66C File Offset: 0x0017C86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaSwitchCommonEnemyProCampRequest()
		{
		}

		// Token: 0x06009D42 RID: 40258 RVA: 0x0017E674 File Offset: 0x0017C874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaSwitchCommonEnemyProCampRequest(GaSwitchCommonEnemyProCampRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D43 RID: 40259 RVA: 0x0017E68D File Offset: 0x0017C88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GaSwitchCommonEnemyProCampRequest Clone()
		{
			return new GaSwitchCommonEnemyProCampRequest(this);
		}

		// Token: 0x06009D44 RID: 40260 RVA: 0x0017E695 File Offset: 0x0017C895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GaSwitchCommonEnemyProCampRequest);
		}

		// Token: 0x06009D45 RID: 40261 RVA: 0x0017E6A3 File Offset: 0x0017C8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GaSwitchCommonEnemyProCampRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009D46 RID: 40262 RVA: 0x0017E6C4 File Offset: 0x0017C8C4
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

		// Token: 0x06009D47 RID: 40263 RVA: 0x0017E6EA File Offset: 0x0017C8EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D48 RID: 40264 RVA: 0x0017E6F7 File Offset: 0x0017C8F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D49 RID: 40265 RVA: 0x0017E700 File Offset: 0x0017C900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D4A RID: 40266 RVA: 0x0017E718 File Offset: 0x0017C918
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

		// Token: 0x06009D4B RID: 40267 RVA: 0x0017E73E File Offset: 0x0017C93E
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

		// Token: 0x06009D4C RID: 40268 RVA: 0x0017E75B File Offset: 0x0017C95B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D4D RID: 40269 RVA: 0x0017E764 File Offset: 0x0017C964
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

		// Token: 0x040049F2 RID: 18930
		private UnknownFieldSet _unknownFields;
	}
}
