using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x0200168A RID: 5770
	[NetMessage(EMessageId.CombatReceivePackNotify)]
	public sealed class CombatReceivePackNotify : IMessage<CombatReceivePackNotify>, IMessage, IEquatable<CombatReceivePackNotify>, IDeepCloneable<CombatReceivePackNotify>, IBufferMessage
	{
		// Token: 0x0601CD79 RID: 118137 RVA: 0x0043123D File Offset: 0x0042F43D
		[NullableContext(1)]
		public static CombatReceivePackNotify Create()
		{
			return new CombatReceivePackNotify();
		}

		// Token: 0x17006183 RID: 24963
		// (get) Token: 0x0601CD7A RID: 118138 RVA: 0x00431244 File Offset: 0x0042F444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006184 RID: 24964
		// (get) Token: 0x0601CD7B RID: 118139 RVA: 0x00431247 File Offset: 0x0042F447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatReceivePackNotify.Descriptor;
			}
		}

		// Token: 0x0601CD7C RID: 118140 RVA: 0x0043124E File Offset: 0x0042F44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatReceivePackNotify()
		{
		}

		// Token: 0x0601CD7D RID: 118141 RVA: 0x00431261 File Offset: 0x0042F461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatReceivePackNotify(CombatReceivePackNotify other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CD7E RID: 118142 RVA: 0x0043128B File Offset: 0x0042F48B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatReceivePackNotify Clone()
		{
			return new CombatReceivePackNotify(this);
		}

		// Token: 0x17006185 RID: 24965
		// (get) Token: 0x0601CD7F RID: 118143 RVA: 0x00431293 File Offset: 0x0042F493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CombatReceiveData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x0601CD80 RID: 118144 RVA: 0x0043129B File Offset: 0x0042F49B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatReceivePackNotify);
		}

		// Token: 0x0601CD81 RID: 118145 RVA: 0x004312A9 File Offset: 0x0042F4A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatReceivePackNotify other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CD82 RID: 118146 RVA: 0x004312DC File Offset: 0x0042F4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.data_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CD83 RID: 118147 RVA: 0x00431310 File Offset: 0x0042F510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CD84 RID: 118148 RVA: 0x0043131D File Offset: 0x0042F51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CD85 RID: 118149 RVA: 0x00431326 File Offset: 0x0042F526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, CombatReceivePackNotify._repeated_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CD86 RID: 118150 RVA: 0x00431350 File Offset: 0x0042F550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(CombatReceivePackNotify._repeated_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CD87 RID: 118151 RVA: 0x00431389 File Offset: 0x0042F589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatReceivePackNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.data_.Add(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CD88 RID: 118152 RVA: 0x004313B7 File Offset: 0x0042F5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CD89 RID: 118153 RVA: 0x004313C0 File Offset: 0x0042F5C0
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
					this.data_.AddEntriesFrom(ref input, CombatReceivePackNotify._repeated_data_codec);
				}
			}
		}

		// Token: 0x0400C2B8 RID: 49848
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C2B9 RID: 49849
		public const int DataFieldNumber = 5;

		// Token: 0x0400C2BA RID: 49850
		private static readonly FieldCodec<CombatReceiveData> _repeated_data_codec = FieldCodec.ForMessage<CombatReceiveData>(42U, CombatReceiveData.Parser);

		// Token: 0x0400C2BB RID: 49851
		private readonly RepeatedField<CombatReceiveData> data_ = new RepeatedField<CombatReceiveData>();
	}
}
