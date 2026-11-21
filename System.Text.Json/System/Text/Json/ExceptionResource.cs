using System;

namespace System.Text.Json
{
	// Token: 0x02000056 RID: 86
	internal enum ExceptionResource
	{
		// Token: 0x0400019A RID: 410
		ArrayDepthTooLarge,
		// Token: 0x0400019B RID: 411
		EndOfCommentNotFound,
		// Token: 0x0400019C RID: 412
		EndOfStringNotFound,
		// Token: 0x0400019D RID: 413
		RequiredDigitNotFoundAfterDecimal,
		// Token: 0x0400019E RID: 414
		RequiredDigitNotFoundAfterSign,
		// Token: 0x0400019F RID: 415
		RequiredDigitNotFoundEndOfData,
		// Token: 0x040001A0 RID: 416
		ExpectedEndAfterSingleJson,
		// Token: 0x040001A1 RID: 417
		ExpectedEndOfDigitNotFound,
		// Token: 0x040001A2 RID: 418
		ExpectedFalse,
		// Token: 0x040001A3 RID: 419
		ExpectedNextDigitEValueNotFound,
		// Token: 0x040001A4 RID: 420
		ExpectedNull,
		// Token: 0x040001A5 RID: 421
		ExpectedSeparatorAfterPropertyNameNotFound,
		// Token: 0x040001A6 RID: 422
		ExpectedStartOfPropertyNotFound,
		// Token: 0x040001A7 RID: 423
		ExpectedStartOfPropertyOrValueNotFound,
		// Token: 0x040001A8 RID: 424
		ExpectedStartOfPropertyOrValueAfterComment,
		// Token: 0x040001A9 RID: 425
		ExpectedStartOfValueNotFound,
		// Token: 0x040001AA RID: 426
		ExpectedTrue,
		// Token: 0x040001AB RID: 427
		ExpectedValueAfterPropertyNameNotFound,
		// Token: 0x040001AC RID: 428
		FoundInvalidCharacter,
		// Token: 0x040001AD RID: 429
		InvalidCharacterWithinString,
		// Token: 0x040001AE RID: 430
		InvalidCharacterAfterEscapeWithinString,
		// Token: 0x040001AF RID: 431
		InvalidHexCharacterWithinString,
		// Token: 0x040001B0 RID: 432
		InvalidEndOfJsonNonPrimitive,
		// Token: 0x040001B1 RID: 433
		MismatchedObjectArray,
		// Token: 0x040001B2 RID: 434
		ObjectDepthTooLarge,
		// Token: 0x040001B3 RID: 435
		ZeroDepthAtEnd,
		// Token: 0x040001B4 RID: 436
		DepthTooLarge,
		// Token: 0x040001B5 RID: 437
		CannotStartObjectArrayWithoutProperty,
		// Token: 0x040001B6 RID: 438
		CannotStartObjectArrayAfterPrimitiveOrClose,
		// Token: 0x040001B7 RID: 439
		CannotWriteValueWithinObject,
		// Token: 0x040001B8 RID: 440
		CannotWriteValueAfterPrimitiveOrClose,
		// Token: 0x040001B9 RID: 441
		CannotWritePropertyWithinArray,
		// Token: 0x040001BA RID: 442
		ExpectedJsonTokens,
		// Token: 0x040001BB RID: 443
		TrailingCommaNotAllowedBeforeArrayEnd,
		// Token: 0x040001BC RID: 444
		TrailingCommaNotAllowedBeforeObjectEnd,
		// Token: 0x040001BD RID: 445
		InvalidCharacterAtStartOfComment,
		// Token: 0x040001BE RID: 446
		UnexpectedEndOfDataWhileReadingComment,
		// Token: 0x040001BF RID: 447
		UnexpectedEndOfLineSeparator,
		// Token: 0x040001C0 RID: 448
		ExpectedOneCompleteToken,
		// Token: 0x040001C1 RID: 449
		NotEnoughData,
		// Token: 0x040001C2 RID: 450
		InvalidLeadingZeroInNumber
	}
}
