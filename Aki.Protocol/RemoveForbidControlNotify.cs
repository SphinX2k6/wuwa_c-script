using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF7 RID: 3831
	[NetMessage(EMessageId.RemoveForbidControlNotify)]
	public sealed class RemoveForbidControlNotify : IMessage<RemoveForbidControlNotify>, IMessage, IEquatable<RemoveForbidControlNotify>, IDeepCloneable<RemoveForbidControlNotify>, IBufferMessage
	{
		// Token: 0x0601486C RID: 84076 RVA: 0x002FB741 File Offset: 0x002F9941
		[NullableContext(1)]
		public static RemoveForbidControlNotify Create()
		{
			return new RemoveForbidControlNotify();
		}

		// Token: 0x17004443 RID: 17475
		// (get) Token: 0x0601486D RID: 84077 RVA: 0x002FB748 File Offset: 0x002F9948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004444 RID: 17476
		// (get) Token: 0x0601486E RID: 84078 RVA: 0x002FB74B File Offset: 0x002F994B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveForbidControlNotify.Descriptor;
			}
		}

		// Token: 0x0601486F RID: 84079 RVA: 0x002FB752 File Offset: 0x002F9952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveForbidControlNotify()
		{
		}

		// Token: 0x06014870 RID: 84080 RVA: 0x002FB765 File Offset: 0x002F9965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveForbidControlNotify(RemoveForbidControlNotify other) : this()
		{
			this.forbidList_ = other.forbidList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014871 RID: 84081 RVA: 0x002FB78F File Offset: 0x002F998F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveForbidControlNotify Clone()
		{
			return new RemoveForbidControlNotify(this);
		}

		// Token: 0x17004445 RID: 17477
		// (get) Token: 0x06014872 RID: 84082 RVA: 0x002FB797 File Offset: 0x002F9997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ControlParam> ForbidList
		{
			get
			{
				return this.forbidList_;
			}
		}

		// Token: 0x06014873 RID: 84083 RVA: 0x002FB79F File Offset: 0x002F999F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveForbidControlNotify);
		}

		// Token: 0x06014874 RID: 84084 RVA: 0x002FB7AD File Offset: 0x002F99AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveForbidControlNotify other)
		{
			return other != null && (other == this || (this.forbidList_.Equals(other.forbidList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014875 RID: 84085 RVA: 0x002FB7E0 File Offset: 0x002F99E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.forbidList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014876 RID: 84086 RVA: 0x002FB814 File Offset: 0x002F9A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014877 RID: 84087 RVA: 0x002FB821 File Offset: 0x002F9A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014878 RID: 84088 RVA: 0x002FB82A File Offset: 0x002F9A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.forbidList_.WriteTo(ref output, RemoveForbidControlNotify._repeated_forbidList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014879 RID: 84089 RVA: 0x002FB854 File Offset: 0x002F9A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.forbidList_.CalculateSize(RemoveForbidControlNotify._repeated_forbidList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601487A RID: 84090 RVA: 0x002FB88D File Offset: 0x002F9A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveForbidControlNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.forbidList_.Add(other.forbidList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601487B RID: 84091 RVA: 0x002FB8BB File Offset: 0x002F9ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601487C RID: 84092 RVA: 0x002FB8C4 File Offset: 0x002F9AC4
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.forbidList_.AddEntriesFrom(ref input, RemoveForbidControlNotify._repeated_forbidList_codec);
				}
			}
		}

		// Token: 0x04007C6E RID: 31854
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C6F RID: 31855
		public const int ForbidListFieldNumber = 12;

		// Token: 0x04007C70 RID: 31856
		private static readonly FieldCodec<ControlParam> _repeated_forbidList_codec = FieldCodec.ForMessage<ControlParam>(98U, ControlParam.Parser);

		// Token: 0x04007C71 RID: 31857
		private readonly RepeatedField<ControlParam> forbidList_ = new RepeatedField<ControlParam>();
	}
}
