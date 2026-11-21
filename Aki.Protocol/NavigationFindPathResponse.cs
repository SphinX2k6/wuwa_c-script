using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ADF RID: 2783
	[NetMessage(EMessageId.NavigationFindPathResponse)]
	public sealed class NavigationFindPathResponse : IMessage<NavigationFindPathResponse>, IMessage, IEquatable<NavigationFindPathResponse>, IDeepCloneable<NavigationFindPathResponse>, IBufferMessage
	{
		// Token: 0x0600F25D RID: 62045 RVA: 0x002368B0 File Offset: 0x00234AB0
		[NullableContext(1)]
		public static NavigationFindPathResponse Create()
		{
			return new NavigationFindPathResponse();
		}

		// Token: 0x17003156 RID: 12630
		// (get) Token: 0x0600F25E RID: 62046 RVA: 0x002368B7 File Offset: 0x00234AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003157 RID: 12631
		// (get) Token: 0x0600F25F RID: 62047 RVA: 0x002368BA File Offset: 0x00234ABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NavigationFindPathResponse.Descriptor;
			}
		}

		// Token: 0x0600F260 RID: 62048 RVA: 0x002368C1 File Offset: 0x00234AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NavigationFindPathResponse()
		{
		}

		// Token: 0x0600F261 RID: 62049 RVA: 0x002368D4 File Offset: 0x00234AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NavigationFindPathResponse(NavigationFindPathResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.posList_ = other.posList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F262 RID: 62050 RVA: 0x0023690A File Offset: 0x00234B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NavigationFindPathResponse Clone()
		{
			return new NavigationFindPathResponse(this);
		}

		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x0600F263 RID: 62051 RVA: 0x00236912 File Offset: 0x00234B12
		// (set) Token: 0x0600F264 RID: 62052 RVA: 0x0023691A File Offset: 0x00234B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x0600F265 RID: 62053 RVA: 0x00236923 File Offset: 0x00234B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Vector> PosList
		{
			get
			{
				return this.posList_;
			}
		}

		// Token: 0x0600F266 RID: 62054 RVA: 0x0023692B File Offset: 0x00234B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NavigationFindPathResponse);
		}

		// Token: 0x0600F267 RID: 62055 RVA: 0x0023693C File Offset: 0x00234B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NavigationFindPathResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.posList_.Equals(other.posList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F268 RID: 62056 RVA: 0x0023698C File Offset: 0x00234B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.posList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F269 RID: 62057 RVA: 0x002369DF File Offset: 0x00234BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F26A RID: 62058 RVA: 0x002369EC File Offset: 0x00234BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F26B RID: 62059 RVA: 0x002369F8 File Offset: 0x00234BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.posList_.WriteTo(ref output, NavigationFindPathResponse._repeated_posList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F26C RID: 62060 RVA: 0x00236A48 File Offset: 0x00234C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.posList_.CalculateSize(NavigationFindPathResponse._repeated_posList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F26D RID: 62061 RVA: 0x00236A9C File Offset: 0x00234C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NavigationFindPathResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.posList_.Add(other.posList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F26E RID: 62062 RVA: 0x00236AE9 File Offset: 0x00234CE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F26F RID: 62063 RVA: 0x00236AF4 File Offset: 0x00234CF4
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
				if (num != 8U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.posList_.AddEntriesFrom(ref input, NavigationFindPathResponse._repeated_posList_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400622A RID: 25130
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400622B RID: 25131
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400622C RID: 25132
		private ErrorCode errorCode_;

		// Token: 0x0400622D RID: 25133
		public const int PosListFieldNumber = 7;

		// Token: 0x0400622E RID: 25134
		private static readonly FieldCodec<Vector> _repeated_posList_codec = FieldCodec.ForMessage<Vector>(58U, Vector.Parser);

		// Token: 0x0400622F RID: 25135
		private readonly RepeatedField<Vector> posList_ = new RepeatedField<Vector>();
	}
}
