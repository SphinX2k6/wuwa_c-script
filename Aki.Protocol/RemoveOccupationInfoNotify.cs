using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF2 RID: 3826
	[NetMessage(EMessageId.RemoveOccupationInfoNotify)]
	public sealed class RemoveOccupationInfoNotify : IMessage<RemoveOccupationInfoNotify>, IMessage, IEquatable<RemoveOccupationInfoNotify>, IDeepCloneable<RemoveOccupationInfoNotify>, IBufferMessage
	{
		// Token: 0x06014863 RID: 84067 RVA: 0x002FBCE5 File Offset: 0x002F9EE5
		[NullableContext(1)]
		public static RemoveOccupationInfoNotify Create()
		{
			return new RemoveOccupationInfoNotify();
		}

		// Token: 0x17004445 RID: 17477
		// (get) Token: 0x06014864 RID: 84068 RVA: 0x002FBCEC File Offset: 0x002F9EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004446 RID: 17478
		// (get) Token: 0x06014865 RID: 84069 RVA: 0x002FBCEF File Offset: 0x002F9EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveOccupationInfoNotify.Descriptor;
			}
		}

		// Token: 0x06014866 RID: 84070 RVA: 0x002FBCF6 File Offset: 0x002F9EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveOccupationInfoNotify()
		{
		}

		// Token: 0x06014867 RID: 84071 RVA: 0x002FBD09 File Offset: 0x002F9F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveOccupationInfoNotify(RemoveOccupationInfoNotify other) : this()
		{
			this.resource_ = other.resource_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014868 RID: 84072 RVA: 0x002FBD33 File Offset: 0x002F9F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveOccupationInfoNotify Clone()
		{
			return new RemoveOccupationInfoNotify(this);
		}

		// Token: 0x17004447 RID: 17479
		// (get) Token: 0x06014869 RID: 84073 RVA: 0x002FBD3B File Offset: 0x002F9F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Resource
		{
			get
			{
				return this.resource_;
			}
		}

		// Token: 0x0601486A RID: 84074 RVA: 0x002FBD43 File Offset: 0x002F9F43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveOccupationInfoNotify);
		}

		// Token: 0x0601486B RID: 84075 RVA: 0x002FBD51 File Offset: 0x002F9F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveOccupationInfoNotify other)
		{
			return other != null && (other == this || (this.resource_.Equals(other.resource_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601486C RID: 84076 RVA: 0x002FBD84 File Offset: 0x002F9F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.resource_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601486D RID: 84077 RVA: 0x002FBDB8 File Offset: 0x002F9FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601486E RID: 84078 RVA: 0x002FBDC5 File Offset: 0x002F9FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601486F RID: 84079 RVA: 0x002FBDCE File Offset: 0x002F9FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.resource_.WriteTo(ref output, RemoveOccupationInfoNotify._repeated_resource_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014870 RID: 84080 RVA: 0x002FBDF8 File Offset: 0x002F9FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.resource_.CalculateSize(RemoveOccupationInfoNotify._repeated_resource_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014871 RID: 84081 RVA: 0x002FBE31 File Offset: 0x002FA031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveOccupationInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.resource_.Add(other.resource_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014872 RID: 84082 RVA: 0x002FBE5F File Offset: 0x002FA05F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014873 RID: 84083 RVA: 0x002FBE68 File Offset: 0x002FA068
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.resource_.AddEntriesFrom(ref input, RemoveOccupationInfoNotify._repeated_resource_codec);
				}
			}
		}

		// Token: 0x04007CD1 RID: 31953
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CD2 RID: 31954
		public const int ResourceFieldNumber = 15;

		// Token: 0x04007CD3 RID: 31955
		private static readonly FieldCodec<string> _repeated_resource_codec = FieldCodec.ForString(122U);

		// Token: 0x04007CD4 RID: 31956
		private readonly RepeatedField<string> resource_ = new RepeatedField<string>();
	}
}
