using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B4E RID: 2894
	[NetMessage(EMessageId.NewTowerSeasonTaskDataUpdateRequest)]
	public sealed class NewTowerSeasonTaskDataUpdateRequest : IMessage<NewTowerSeasonTaskDataUpdateRequest>, IMessage, IEquatable<NewTowerSeasonTaskDataUpdateRequest>, IDeepCloneable<NewTowerSeasonTaskDataUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600FAF9 RID: 64249 RVA: 0x002494B9 File Offset: 0x002476B9
		[NullableContext(1)]
		public static NewTowerSeasonTaskDataUpdateRequest Create()
		{
			return new NewTowerSeasonTaskDataUpdateRequest();
		}

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x0600FAFA RID: 64250 RVA: 0x002494C0 File Offset: 0x002476C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x0600FAFB RID: 64251 RVA: 0x002494C3 File Offset: 0x002476C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerSeasonTaskDataUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0600FAFC RID: 64252 RVA: 0x002494CA File Offset: 0x002476CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateRequest()
		{
		}

		// Token: 0x0600FAFD RID: 64253 RVA: 0x002494D2 File Offset: 0x002476D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateRequest(NewTowerSeasonTaskDataUpdateRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FAFE RID: 64254 RVA: 0x002494EB File Offset: 0x002476EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonTaskDataUpdateRequest Clone()
		{
			return new NewTowerSeasonTaskDataUpdateRequest(this);
		}

		// Token: 0x0600FAFF RID: 64255 RVA: 0x002494F3 File Offset: 0x002476F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerSeasonTaskDataUpdateRequest);
		}

		// Token: 0x0600FB00 RID: 64256 RVA: 0x00249501 File Offset: 0x00247701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerSeasonTaskDataUpdateRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600FB01 RID: 64257 RVA: 0x00249520 File Offset: 0x00247720
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

		// Token: 0x0600FB02 RID: 64258 RVA: 0x00249546 File Offset: 0x00247746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB03 RID: 64259 RVA: 0x00249553 File Offset: 0x00247753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB04 RID: 64260 RVA: 0x0024955C File Offset: 0x0024775C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FB05 RID: 64261 RVA: 0x00249574 File Offset: 0x00247774
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

		// Token: 0x0600FB06 RID: 64262 RVA: 0x0024959A File Offset: 0x0024779A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerSeasonTaskDataUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FB07 RID: 64263 RVA: 0x002495B7 File Offset: 0x002477B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB08 RID: 64264 RVA: 0x002495C0 File Offset: 0x002477C0
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

		// Token: 0x04006467 RID: 25703
		private UnknownFieldSet _unknownFields;
	}
}
