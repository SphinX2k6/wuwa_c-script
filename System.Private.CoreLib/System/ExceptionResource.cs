using System;

namespace System
{
	// Token: 0x020001C4 RID: 452
	internal enum ExceptionResource
	{
		// Token: 0x040005F7 RID: 1527
		ArgumentOutOfRange_IndexMustBeLessOrEqual,
		// Token: 0x040005F8 RID: 1528
		ArgumentOutOfRange_IndexMustBeLess,
		// Token: 0x040005F9 RID: 1529
		ArgumentOutOfRange_IndexCount,
		// Token: 0x040005FA RID: 1530
		ArgumentOutOfRange_IndexCountBuffer,
		// Token: 0x040005FB RID: 1531
		ArgumentOutOfRange_Count,
		// Token: 0x040005FC RID: 1532
		ArgumentOutOfRange_Year,
		// Token: 0x040005FD RID: 1533
		Arg_ArrayPlusOffTooSmall,
		// Token: 0x040005FE RID: 1534
		Arg_ByteArrayTooSmallForValue,
		// Token: 0x040005FF RID: 1535
		NotSupported_ReadOnlyCollection,
		// Token: 0x04000600 RID: 1536
		Arg_RankMultiDimNotSupported,
		// Token: 0x04000601 RID: 1537
		Arg_NonZeroLowerBound,
		// Token: 0x04000602 RID: 1538
		ArgumentOutOfRange_GetCharCountOverflow,
		// Token: 0x04000603 RID: 1539
		ArgumentOutOfRange_ListInsert,
		// Token: 0x04000604 RID: 1540
		ArgumentOutOfRange_NeedNonNegNum,
		// Token: 0x04000605 RID: 1541
		ArgumentOutOfRange_NotGreaterThanBufferLength,
		// Token: 0x04000606 RID: 1542
		ArgumentOutOfRange_SmallCapacity,
		// Token: 0x04000607 RID: 1543
		Argument_InvalidOffLen,
		// Token: 0x04000608 RID: 1544
		Argument_CannotExtractScalar,
		// Token: 0x04000609 RID: 1545
		ArgumentOutOfRange_BiggerThanCollection,
		// Token: 0x0400060A RID: 1546
		Serialization_MissingKeys,
		// Token: 0x0400060B RID: 1547
		Serialization_NullKey,
		// Token: 0x0400060C RID: 1548
		NotSupported_KeyCollectionSet,
		// Token: 0x0400060D RID: 1549
		NotSupported_ValueCollectionSet,
		// Token: 0x0400060E RID: 1550
		InvalidOperation_NullArray,
		// Token: 0x0400060F RID: 1551
		TaskT_TransitionToFinal_AlreadyCompleted,
		// Token: 0x04000610 RID: 1552
		TaskCompletionSourceT_TrySetException_NullException,
		// Token: 0x04000611 RID: 1553
		TaskCompletionSourceT_TrySetException_NoExceptions,
		// Token: 0x04000612 RID: 1554
		NotSupported_StringComparison,
		// Token: 0x04000613 RID: 1555
		ConcurrentCollection_SyncRoot_NotSupported,
		// Token: 0x04000614 RID: 1556
		Task_MultiTaskContinuation_NullTask,
		// Token: 0x04000615 RID: 1557
		InvalidOperation_WrongAsyncResultOrEndCalledMultiple,
		// Token: 0x04000616 RID: 1558
		Task_MultiTaskContinuation_EmptyTaskList,
		// Token: 0x04000617 RID: 1559
		Task_Start_TaskCompleted,
		// Token: 0x04000618 RID: 1560
		Task_Start_Promise,
		// Token: 0x04000619 RID: 1561
		Task_Start_ContinuationTask,
		// Token: 0x0400061A RID: 1562
		Task_Start_AlreadyStarted,
		// Token: 0x0400061B RID: 1563
		Task_RunSynchronously_Continuation,
		// Token: 0x0400061C RID: 1564
		Task_RunSynchronously_Promise,
		// Token: 0x0400061D RID: 1565
		Task_RunSynchronously_TaskCompleted,
		// Token: 0x0400061E RID: 1566
		Task_RunSynchronously_AlreadyStarted,
		// Token: 0x0400061F RID: 1567
		AsyncMethodBuilder_InstanceNotInitialized,
		// Token: 0x04000620 RID: 1568
		Task_ContinueWith_ESandLR,
		// Token: 0x04000621 RID: 1569
		Task_ContinueWith_NotOnAnything,
		// Token: 0x04000622 RID: 1570
		Task_InvalidTimerTimeSpan,
		// Token: 0x04000623 RID: 1571
		Task_Delay_InvalidMillisecondsDelay,
		// Token: 0x04000624 RID: 1572
		Task_Dispose_NotCompleted,
		// Token: 0x04000625 RID: 1573
		Task_ThrowIfDisposed,
		// Token: 0x04000626 RID: 1574
		Task_WaitMulti_NullTask,
		// Token: 0x04000627 RID: 1575
		ArgumentException_OtherNotArrayOfCorrectLength,
		// Token: 0x04000628 RID: 1576
		ArgumentNull_Array,
		// Token: 0x04000629 RID: 1577
		ArgumentNull_SafeHandle,
		// Token: 0x0400062A RID: 1578
		ArgumentOutOfRange_EndIndexStartIndex,
		// Token: 0x0400062B RID: 1579
		ArgumentOutOfRange_Enum,
		// Token: 0x0400062C RID: 1580
		ArgumentOutOfRange_HugeArrayNotSupported,
		// Token: 0x0400062D RID: 1581
		Argument_AddingDuplicate,
		// Token: 0x0400062E RID: 1582
		Argument_InvalidArgumentForComparison,
		// Token: 0x0400062F RID: 1583
		Arg_LowerBoundsMustMatch,
		// Token: 0x04000630 RID: 1584
		Arg_MustBeType,
		// Token: 0x04000631 RID: 1585
		Arg_Need1DArray,
		// Token: 0x04000632 RID: 1586
		Arg_Need2DArray,
		// Token: 0x04000633 RID: 1587
		Arg_Need3DArray,
		// Token: 0x04000634 RID: 1588
		Arg_NeedAtLeast1Rank,
		// Token: 0x04000635 RID: 1589
		Arg_RankIndices,
		// Token: 0x04000636 RID: 1590
		Arg_RanksAndBounds,
		// Token: 0x04000637 RID: 1591
		InvalidOperation_IComparerFailed,
		// Token: 0x04000638 RID: 1592
		NotSupported_FixedSizeCollection,
		// Token: 0x04000639 RID: 1593
		Rank_MultiDimNotSupported,
		// Token: 0x0400063A RID: 1594
		Arg_TypeNotSupported,
		// Token: 0x0400063B RID: 1595
		Argument_SpansMustHaveSameLength,
		// Token: 0x0400063C RID: 1596
		Argument_InvalidFlag,
		// Token: 0x0400063D RID: 1597
		CancellationTokenSource_Disposed,
		// Token: 0x0400063E RID: 1598
		Argument_AlignmentMustBePow2,
		// Token: 0x0400063F RID: 1599
		InvalidOperation_SpanOverlappedOperation,
		// Token: 0x04000640 RID: 1600
		InvalidOperation_TimeProviderNullLocalTimeZone,
		// Token: 0x04000641 RID: 1601
		InvalidOperation_TimeProviderInvalidTimestampFrequency,
		// Token: 0x04000642 RID: 1602
		Format_UnexpectedClosingBrace,
		// Token: 0x04000643 RID: 1603
		Format_UnclosedFormatItem,
		// Token: 0x04000644 RID: 1604
		Format_ExpectedAsciiDigit,
		// Token: 0x04000645 RID: 1605
		Argument_HasToBeArrayClass,
		// Token: 0x04000646 RID: 1606
		InvalidOperation_IncompatibleComparer
	}
}
