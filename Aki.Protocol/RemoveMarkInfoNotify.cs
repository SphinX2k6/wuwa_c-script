using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF1 RID: 3825
	[NetMessage(EMessageId.RemoveMarkInfoNotify)]
	public sealed class RemoveMarkInfoNotify : IMessage<RemoveMarkInfoNotify>, IMessage, IEquatable<RemoveMarkInfoNotify>, IDeepCloneable<RemoveMarkInfoNotify>, IBufferMessage
	{
		// Token: 0x06014851 RID: 84049 RVA: 0x002FBB04 File Offset: 0x002F9D04
		[NullableContext(1)]
		public static RemoveMarkInfoNotify Create()
		{
			return new RemoveMarkInfoNotify();
		}

		// Token: 0x17004442 RID: 17474
		// (get) Token: 0x06014852 RID: 84050 RVA: 0x002FBB0B File Offset: 0x002F9D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004443 RID: 17475
		// (get) Token: 0x06014853 RID: 84051 RVA: 0x002FBB0E File Offset: 0x002F9D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveMarkInfoNotify.Descriptor;
			}
		}

		// Token: 0x06014854 RID: 84052 RVA: 0x002FBB15 File Offset: 0x002F9D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveMarkInfoNotify()
		{
		}

		// Token: 0x06014855 RID: 84053 RVA: 0x002FBB28 File Offset: 0x002F9D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveMarkInfoNotify(RemoveMarkInfoNotify other) : this()
		{
			this.markIds_ = other.markIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014856 RID: 84054 RVA: 0x002FBB52 File Offset: 0x002F9D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveMarkInfoNotify Clone()
		{
			return new RemoveMarkInfoNotify(this);
		}

		// Token: 0x17004444 RID: 17476
		// (get) Token: 0x06014857 RID: 84055 RVA: 0x002FBB5A File Offset: 0x002F9D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MarkIds
		{
			get
			{
				return this.markIds_;
			}
		}

		// Token: 0x06014858 RID: 84056 RVA: 0x002FBB62 File Offset: 0x002F9D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveMarkInfoNotify);
		}

		// Token: 0x06014859 RID: 84057 RVA: 0x002FBB70 File Offset: 0x002F9D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveMarkInfoNotify other)
		{
			return other != null && (other == this || (this.markIds_.Equals(other.markIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601485A RID: 84058 RVA: 0x002FBBA4 File Offset: 0x002F9DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.markIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601485B RID: 84059 RVA: 0x002FBBD8 File Offset: 0x002F9DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601485C RID: 84060 RVA: 0x002FBBE5 File Offset: 0x002F9DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601485D RID: 84061 RVA: 0x002FBBEE File Offset: 0x002F9DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.markIds_.WriteTo(ref output, RemoveMarkInfoNotify._repeated_markIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601485E RID: 84062 RVA: 0x002FBC18 File Offset: 0x002F9E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.markIds_.CalculateSize(RemoveMarkInfoNotify._repeated_markIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601485F RID: 84063 RVA: 0x002FBC51 File Offset: 0x002F9E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveMarkInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.markIds_.Add(other.markIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014860 RID: 84064 RVA: 0x002FBC7F File Offset: 0x002F9E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014861 RID: 84065 RVA: 0x002FBC88 File Offset: 0x002F9E88
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.markIds_.AddEntriesFrom(ref input, RemoveMarkInfoNotify._repeated_markIds_codec);
				}
			}
		}

		// Token: 0x04007CCD RID: 31949
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CCE RID: 31950
		public const int MarkIdsFieldNumber = 10;

		// Token: 0x04007CCF RID: 31951
		private static readonly FieldCodec<int> _repeated_markIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04007CD0 RID: 31952
		private readonly RepeatedField<int> markIds_ = new RepeatedField<int>();
	}
}
