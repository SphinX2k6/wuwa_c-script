using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E8E RID: 3726
	[NetMessage(EMessageId.RealmBetweenLevelUpRequest)]
	public sealed class RealmBetweenLevelUpRequest : IMessage<RealmBetweenLevelUpRequest>, IMessage, IEquatable<RealmBetweenLevelUpRequest>, IDeepCloneable<RealmBetweenLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0601408A RID: 82058 RVA: 0x002EB4F1 File Offset: 0x002E96F1
		[NullableContext(1)]
		public static RealmBetweenLevelUpRequest Create()
		{
			return new RealmBetweenLevelUpRequest();
		}

		// Token: 0x170042AB RID: 17067
		// (get) Token: 0x0601408B RID: 82059 RVA: 0x002EB4F8 File Offset: 0x002E96F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042AC RID: 17068
		// (get) Token: 0x0601408C RID: 82060 RVA: 0x002EB4FB File Offset: 0x002E96FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RealmBetweenLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0601408D RID: 82061 RVA: 0x002EB502 File Offset: 0x002E9702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenLevelUpRequest()
		{
		}

		// Token: 0x0601408E RID: 82062 RVA: 0x002EB50A File Offset: 0x002E970A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenLevelUpRequest(RealmBetweenLevelUpRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601408F RID: 82063 RVA: 0x002EB523 File Offset: 0x002E9723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RealmBetweenLevelUpRequest Clone()
		{
			return new RealmBetweenLevelUpRequest(this);
		}

		// Token: 0x06014090 RID: 82064 RVA: 0x002EB52B File Offset: 0x002E972B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RealmBetweenLevelUpRequest);
		}

		// Token: 0x06014091 RID: 82065 RVA: 0x002EB539 File Offset: 0x002E9739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RealmBetweenLevelUpRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06014092 RID: 82066 RVA: 0x002EB558 File Offset: 0x002E9758
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

		// Token: 0x06014093 RID: 82067 RVA: 0x002EB57E File Offset: 0x002E977E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014094 RID: 82068 RVA: 0x002EB58B File Offset: 0x002E978B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014095 RID: 82069 RVA: 0x002EB594 File Offset: 0x002E9794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014096 RID: 82070 RVA: 0x002EB5AC File Offset: 0x002E97AC
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

		// Token: 0x06014097 RID: 82071 RVA: 0x002EB5D2 File Offset: 0x002E97D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RealmBetweenLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014098 RID: 82072 RVA: 0x002EB5EF File Offset: 0x002E97EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014099 RID: 82073 RVA: 0x002EB5F8 File Offset: 0x002E97F8
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

		// Token: 0x04007AA7 RID: 31399
		private UnknownFieldSet _unknownFields;
	}
}
