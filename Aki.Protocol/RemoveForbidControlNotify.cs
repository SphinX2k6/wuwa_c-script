using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE7 RID: 3815
	[NetMessage(EMessageId.RemoveForbidControlNotify)]
	public sealed class RemoveForbidControlNotify : IMessage<RemoveForbidControlNotify>, IMessage, IEquatable<RemoveForbidControlNotify>, IDeepCloneable<RemoveForbidControlNotify>, IBufferMessage
	{
		// Token: 0x06014787 RID: 83847 RVA: 0x002FA08D File Offset: 0x002F828D
		[NullableContext(1)]
		public static RemoveForbidControlNotify Create()
		{
			return new RemoveForbidControlNotify();
		}

		// Token: 0x17004419 RID: 17433
		// (get) Token: 0x06014788 RID: 83848 RVA: 0x002FA094 File Offset: 0x002F8294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700441A RID: 17434
		// (get) Token: 0x06014789 RID: 83849 RVA: 0x002FA097 File Offset: 0x002F8297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveForbidControlNotify.Descriptor;
			}
		}

		// Token: 0x0601478A RID: 83850 RVA: 0x002FA09E File Offset: 0x002F829E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveForbidControlNotify()
		{
		}

		// Token: 0x0601478B RID: 83851 RVA: 0x002FA0B1 File Offset: 0x002F82B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveForbidControlNotify(RemoveForbidControlNotify other) : this()
		{
			this.forbidList_ = other.forbidList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601478C RID: 83852 RVA: 0x002FA0DB File Offset: 0x002F82DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveForbidControlNotify Clone()
		{
			return new RemoveForbidControlNotify(this);
		}

		// Token: 0x1700441B RID: 17435
		// (get) Token: 0x0601478D RID: 83853 RVA: 0x002FA0E3 File Offset: 0x002F82E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ControlParam> ForbidList
		{
			get
			{
				return this.forbidList_;
			}
		}

		// Token: 0x0601478E RID: 83854 RVA: 0x002FA0EB File Offset: 0x002F82EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveForbidControlNotify);
		}

		// Token: 0x0601478F RID: 83855 RVA: 0x002FA0F9 File Offset: 0x002F82F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveForbidControlNotify other)
		{
			return other != null && (other == this || (this.forbidList_.Equals(other.forbidList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014790 RID: 83856 RVA: 0x002FA12C File Offset: 0x002F832C
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

		// Token: 0x06014791 RID: 83857 RVA: 0x002FA160 File Offset: 0x002F8360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014792 RID: 83858 RVA: 0x002FA16D File Offset: 0x002F836D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014793 RID: 83859 RVA: 0x002FA176 File Offset: 0x002F8376
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

		// Token: 0x06014794 RID: 83860 RVA: 0x002FA1A0 File Offset: 0x002F83A0
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

		// Token: 0x06014795 RID: 83861 RVA: 0x002FA1D9 File Offset: 0x002F83D9
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

		// Token: 0x06014796 RID: 83862 RVA: 0x002FA207 File Offset: 0x002F8407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014797 RID: 83863 RVA: 0x002FA210 File Offset: 0x002F8410
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.forbidList_.AddEntriesFrom(ref input, RemoveForbidControlNotify._repeated_forbidList_codec);
				}
			}
		}

		// Token: 0x04007C98 RID: 31896
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C99 RID: 31897
		public const int ForbidListFieldNumber = 5;

		// Token: 0x04007C9A RID: 31898
		private static readonly FieldCodec<ControlParam> _repeated_forbidList_codec = FieldCodec.ForMessage<ControlParam>(42U, ControlParam.Parser);

		// Token: 0x04007C9B RID: 31899
		private readonly RepeatedField<ControlParam> forbidList_ = new RepeatedField<ControlParam>();
	}
}
