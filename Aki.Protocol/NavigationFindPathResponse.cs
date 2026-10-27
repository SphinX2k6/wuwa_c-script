using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF0 RID: 2800
	[NetMessage(EMessageId.NavigationFindPathResponse)]
	public sealed class NavigationFindPathResponse : IMessage<NavigationFindPathResponse>, IMessage, IEquatable<NavigationFindPathResponse>, IDeepCloneable<NavigationFindPathResponse>, IBufferMessage
	{
		// Token: 0x0600F377 RID: 62327 RVA: 0x00238AB8 File Offset: 0x00236CB8
		[NullableContext(1)]
		public static NavigationFindPathResponse Create()
		{
			return new NavigationFindPathResponse();
		}

		// Token: 0x17003194 RID: 12692
		// (get) Token: 0x0600F378 RID: 62328 RVA: 0x00238ABF File Offset: 0x00236CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003195 RID: 12693
		// (get) Token: 0x0600F379 RID: 62329 RVA: 0x00238AC2 File Offset: 0x00236CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NavigationFindPathResponse.Descriptor;
			}
		}

		// Token: 0x0600F37A RID: 62330 RVA: 0x00238AC9 File Offset: 0x00236CC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NavigationFindPathResponse()
		{
		}

		// Token: 0x0600F37B RID: 62331 RVA: 0x00238ADC File Offset: 0x00236CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NavigationFindPathResponse(NavigationFindPathResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.posList_ = other.posList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F37C RID: 62332 RVA: 0x00238B12 File Offset: 0x00236D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NavigationFindPathResponse Clone()
		{
			return new NavigationFindPathResponse(this);
		}

		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x0600F37D RID: 62333 RVA: 0x00238B1A File Offset: 0x00236D1A
		// (set) Token: 0x0600F37E RID: 62334 RVA: 0x00238B22 File Offset: 0x00236D22
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

		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x0600F37F RID: 62335 RVA: 0x00238B2B File Offset: 0x00236D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Vector> PosList
		{
			get
			{
				return this.posList_;
			}
		}

		// Token: 0x0600F380 RID: 62336 RVA: 0x00238B33 File Offset: 0x00236D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NavigationFindPathResponse);
		}

		// Token: 0x0600F381 RID: 62337 RVA: 0x00238B44 File Offset: 0x00236D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NavigationFindPathResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.posList_.Equals(other.posList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F382 RID: 62338 RVA: 0x00238B94 File Offset: 0x00236D94
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

		// Token: 0x0600F383 RID: 62339 RVA: 0x00238BE7 File Offset: 0x00236DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F384 RID: 62340 RVA: 0x00238BF4 File Offset: 0x00236DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F385 RID: 62341 RVA: 0x00238C00 File Offset: 0x00236E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.posList_.WriteTo(ref output, NavigationFindPathResponse._repeated_posList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F386 RID: 62342 RVA: 0x00238C50 File Offset: 0x00236E50
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

		// Token: 0x0600F387 RID: 62343 RVA: 0x00238CA4 File Offset: 0x00236EA4
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

		// Token: 0x0600F388 RID: 62344 RVA: 0x00238CF1 File Offset: 0x00236EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F389 RID: 62345 RVA: 0x00238CFC File Offset: 0x00236EFC
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
				if (num != 56U)
				{
					if (num != 98U)
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

		// Token: 0x04006221 RID: 25121
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006222 RID: 25122
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04006223 RID: 25123
		private ErrorCode errorCode_;

		// Token: 0x04006224 RID: 25124
		public const int PosListFieldNumber = 12;

		// Token: 0x04006225 RID: 25125
		private static readonly FieldCodec<Vector> _repeated_posList_codec = FieldCodec.ForMessage<Vector>(98U, Vector.Parser);

		// Token: 0x04006226 RID: 25126
		private readonly RepeatedField<Vector> posList_ = new RepeatedField<Vector>();
	}
}
